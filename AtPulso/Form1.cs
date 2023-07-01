using AtPulso.Utils;
using AtPulso.Utils.Events;
using AtPulso.Utils.Schema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Devices.Enumeration;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;
using System.Configuration;

namespace AtPulso
{
	public partial class Form1 : Form
	{
		private string version = "1.4";

		public ObservableCollection<WatcherDevice> devices = new ObservableCollection<WatcherDevice>();
		private HeartRateMonitor _heartRateMonitor = new HeartRateMonitor();

		private int lastBpm = 0;

		HttpListener serverListener = new HttpListener();
		bool serverStarted = false;
		CancellationTokenSource tokenSource;
		CancellationToken serverStopToken;

		bool disconnectedByButton = false;

		WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
		FormPreview fp = new FormPreview();

		public Form1()
		{
			InitializeComponent();
			fp.parent = this;
		}

		private void Log(string str)
		{
			lbLog.Invoke((MethodInvoker) delegate {
				lbLog.Items.Insert(0, str);
			});
		}

		private void RecalculateObsWidth()
		{
			int width = 0;
			switch (cbOutputMode.SelectedIndex)
			{
				case 0: width = (int)nudChartWidth.Value + 150 + 150; break; // All
				case 1: width = (int)nudChartWidth.Value + 150; break; // Chart + HR
				case 2: width = 150 + 150; break; // HR + Anim
				case 3: width = 150; break; // HR
			}
			tbObsWidth.Text = width.ToString();
			fp.width = width;
		}

		private void UpdateUiBySettings()
		{
			try
			{
				cbAutoConnectAtStart.Checked = bool.Parse(Properties.Settings.Default.AutoConnectAtStart);
				cbHideAtStart.Checked = bool.Parse(Properties.Settings.Default.HideAtStart);
				cbRetryConnect.Checked = bool.Parse(Properties.Settings.Default.RetryConnectWhenFailed);
				cbServerAutostart.Checked = bool.Parse(Properties.Settings.Default.AutoStartServerWhenConnected);
				cbSoundAlert.Checked = bool.Parse(Properties.Settings.Default.SoundAlert);
				cbAutoShowPreview.Checked = bool.Parse(Properties.Settings.Default.PreviewAutostart);

				tbDeviceId.Text = Properties.Settings.Default.BleDeviceId;

				nudServerPort.Value = decimal.Parse(Properties.Settings.Default.ServerPort.Replace(".", ","));

				cbOutputMode.SelectedIndex = int.Parse(Properties.Settings.Default.OutputMode);
				cbOutputOrientation.SelectedIndex = int.Parse(Properties.Settings.Default.OutputOrientation);
				tbFontFamily.Text = Properties.Settings.Default.FontFamily;

				tbHeartRateColor.Text = Properties.Settings.Default.HeartRateColor;
				nudHeartRateFontSize.Value = decimal.Parse(Properties.Settings.Default.HeartRateFontSize.Replace(".", ","));
				tbHeartRateThresholdColor.Text = Properties.Settings.Default.HeartRateThresholdColor;
				cbHeartRateThresholdChange.Checked = bool.Parse(Properties.Settings.Default.HeartRateThresholdChange);
				nudHeartRateThreshold.Value = decimal.Parse(Properties.Settings.Default.HeartRateThreshold.Replace(".", ","));
				switch (Properties.Settings.Default.HeartRateStyle)
				{
					case "glow": cbHeartRateOutlineStyle.SelectedIndex = 1; break;
					case "black_border": cbHeartRateOutlineStyle.SelectedIndex = 2; break;
					case "white_border": cbHeartRateOutlineStyle.SelectedIndex = 3; break;
					default: cbHeartRateOutlineStyle.SelectedIndex = 0; break;
				}

				nudChartDotsCount.Value = decimal.Parse(Properties.Settings.Default.ChartDotsCount.Replace(".", ","));
				nudChartWidth.Value = decimal.Parse(Properties.Settings.Default.ChartWidth.Replace(".", ","));
				tbLineColor.Text = Properties.Settings.Default.LineColor;
				tbMinMaxColor.Text = Properties.Settings.Default.MinMaxColor;
				nudChartLineThickness.Value = decimal.Parse(Properties.Settings.Default.ChartLineThickness.Replace(".", ","));
				cbChartLineSmooth.Checked = bool.Parse(Properties.Settings.Default.ChartLineSmooth);

				tbAnimationPath.Text = Properties.Settings.Default.AnimationPath;
				nudAnimSpeedMultiplier.Value = decimal.Parse(Properties.Settings.Default.AnimationSpeedMultiplier.Replace(".", ","));
				tbAnimFilter.Text = Properties.Settings.Default.AnimationFilter;

				fp.bgIndex = int.Parse(Properties.Settings.Default.PreviewBackgroundColor);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\nSettings will be resetted.", "AtPulso - Load Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Properties.Settings.Default.Reset();
				UpdateUiBySettings();
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			this.Text = String.Format("AtPulso by GoodVrGames v{0}", version);
			UpdateUiBySettings(); 

			// we should always monitor the connection status
			//_heartRateMonitor.ConnectionStatusChanged -= HrDeviceOnDeviceConnectionStatusChanged;
			_heartRateMonitor.ConnectionStatusChanged += HrDeviceOnDeviceConnectionStatusChanged;

			//// we can create value parser and listen for parsed values of given characteristic
			//HrParser.ConnectWithCharacteristic(HrDevice.HeartRate.HeartRateMeasurement);
			//_heartRateMonitor.RateChanged -= HrParserOnValueChanged;
			_heartRateMonitor.RateChanged += HrParserOnValueChanged;

			if (bool.Parse(Properties.Settings.Default.AutoConnectAtStart))
			{
				if (!string.IsNullOrEmpty(Properties.Settings.Default.BleDeviceId))
				{
					ConnectToBt();
					if (bool.Parse(Properties.Settings.Default.HideAtStart))
					{
						tiHideOnStart.Start();
					}
				}
			}
		}

		public void UpdateBackgroundSetting(int newVal)
		{
			Properties.Settings.Default.PreviewBackgroundColor = newVal.ToString();
			Properties.Settings.Default.Save();
		}

		#region UIAppSettings

		private void cbHideAtStart_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HideAtStart = cbHideAtStart.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbAutoConnectAndHide_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoConnectAtStart = cbAutoConnectAtStart.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbRetryConnect_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.RetryConnectWhenFailed = cbRetryConnect.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbServerAutostart_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoStartServerWhenConnected = cbServerAutostart.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbAutoShowPreview_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.PreviewAutostart = cbAutoShowPreview.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbSoundAlert_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.SoundAlert = cbSoundAlert.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		#endregion

		#region UIServerSettings

		private void nudServerPort_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ServerPort = nudServerPort.Value.ToString();
			Properties.Settings.Default.Save();
		}

		#endregion

		#region UIOutputSettings

		private void cbOutputMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OutputMode = cbOutputMode.SelectedIndex.ToString();
			Properties.Settings.Default.Save();
			RecalculateObsWidth();
			switch (cbOutputMode.SelectedIndex)
			{
				case 0: gbChartSettings.Enabled = true; gbHeartRateSettings.Enabled = true; gbAnimationSettings.Enabled = true; break; // All
				case 1: gbChartSettings.Enabled = true; gbHeartRateSettings.Enabled = true; gbAnimationSettings.Enabled = false; break; // Chart + HR
				case 2: gbChartSettings.Enabled = false; gbHeartRateSettings.Enabled = true; gbAnimationSettings.Enabled = true; break; // HR + Anim
				case 3: gbChartSettings.Enabled = false; gbHeartRateSettings.Enabled = true; gbAnimationSettings.Enabled = false; break; // HR
			}
		}

		private void cbOutputOrientation_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OutputOrientation = cbOutputOrientation.SelectedIndex.ToString();
			Properties.Settings.Default.Save();
		}

		bool tbFontFamily_TextChangedByCode = false;
		private void tbFontFamily_TextChanged(object sender, EventArgs e)
		{
			if (tbFontFamily_TextChangedByCode)
			{
				tbFontFamily_TextChangedByCode = false;
				return;
			}
			if (string.IsNullOrEmpty(tbFontFamily.Text))
			{
				tbFontFamily_TextChangedByCode = true;
				tbFontFamily.Text = "cursive";
			}
			Properties.Settings.Default.FontFamily = tbFontFamily.Text;
			Properties.Settings.Default.Save();
		}

		private void buOpenCssFontPage_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.w3schools.com/css/css_font.asp");
		}


		private void nudChartDotsCount_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartDotsCount = nudChartDotsCount.Value.ToString();
			Properties.Settings.Default.Save();
		}

		private void nudChartWidth_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartWidth = nudChartWidth.Value.ToString();
			Properties.Settings.Default.Save();
			RecalculateObsWidth();
		}

		private void buLineColor_Click(object sender, EventArgs e)
		{
			if (cdSelectColor.ShowDialog() == DialogResult.OK)
			{
				byte[] input = new byte[] { cdSelectColor.Color.R, cdSelectColor.Color.G, cdSelectColor.Color.B };
				string output = "#" + BitConverter.ToString(input).Replace("-", "");
				tbLineColor.Text = output;
				Properties.Settings.Default.LineColor = output;
				Properties.Settings.Default.Save();
			}			
		}

		private void buMinMaxColor_Click(object sender, EventArgs e)
		{
			if (cdSelectColor.ShowDialog() == DialogResult.OK)
			{
				byte[] input = new byte[] { cdSelectColor.Color.R, cdSelectColor.Color.G, cdSelectColor.Color.B };
				string output = "#" + BitConverter.ToString(input).Replace("-", "");
				tbMinMaxColor.Text = output;
				Properties.Settings.Default.MinMaxColor = output;
				Properties.Settings.Default.Save();
			}
		}

		private void nudChartLineWidth_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartLineThickness = nudChartLineThickness.Value.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbChartLineSmooth_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartLineSmooth = cbChartLineSmooth.Checked.ToString();
			Properties.Settings.Default.Save();
		}


		private void buHeartRateColor_Click(object sender, EventArgs e)
		{
			if (cdSelectColor.ShowDialog() == DialogResult.OK)
			{
				byte[] input = new byte[] { cdSelectColor.Color.R, cdSelectColor.Color.G, cdSelectColor.Color.B };
				string output = "#" + BitConverter.ToString(input).Replace("-", "");
				tbHeartRateColor.Text = output;
				Properties.Settings.Default.HeartRateColor = output;
				Properties.Settings.Default.Save();
			}
		}

		private void cbHeartRateOutlineStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbHeartRateOutlineStyle.SelectedIndex)
			{
				case 1: Properties.Settings.Default.HeartRateStyle = "glow"; break;
				case 2: Properties.Settings.Default.HeartRateStyle = "black_border"; break;
				case 3: Properties.Settings.Default.HeartRateStyle = "white_border"; break;
				default: Properties.Settings.Default.HeartRateStyle = ""; break;
			}
			Properties.Settings.Default.Save();
		}

		private void nudFontSize_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateFontSize = nudHeartRateFontSize.Value.ToString();
			Properties.Settings.Default.Save();
		}

		private void cbHeartRateThresholdChange_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateThresholdChange = cbHeartRateThresholdChange.Checked.ToString();
			Properties.Settings.Default.Save();
		}

		private void nudHeartRateThreshold_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateThreshold = nudHeartRateThreshold.Value.ToString();
			Properties.Settings.Default.Save();
		}

		private void buHeartRateThresholdColor_Click(object sender, EventArgs e)
		{
			if (cdSelectColor.ShowDialog() == DialogResult.OK)
			{
				byte[] input = new byte[] { cdSelectColor.Color.R, cdSelectColor.Color.G, cdSelectColor.Color.B };
				string output = "#" + BitConverter.ToString(input).Replace("-", "");
				tbHeartRateThresholdColor.Text = output;
				Properties.Settings.Default.HeartRateThresholdColor = output;
				Properties.Settings.Default.Save();
			}
		}


		private void buAnimationSelect_Click(object sender, EventArgs e)
		{
			if (ofdSelectAnimation.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.AnimationPath = ofdSelectAnimation.FileName;
				Properties.Settings.Default.Save();
				tbAnimationPath.Text = ofdSelectAnimation.FileName;
			}
		}

		private void buAnimationClear_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationPath = "";
			Properties.Settings.Default.Save();
			tbAnimationPath.Text = "";
		}

		private void nudAnimSpeedMultiplier_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationSpeedMultiplier = nudAnimSpeedMultiplier.Value.ToString();
			Properties.Settings.Default.Save();
		}

		private void tbAnimFilter_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationFilter = tbAnimFilter.Text;
			Properties.Settings.Default.Save();
		}

		private void buOpenFilterPage_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://codepen.io/sosuke/pen/Pjoqqp");
		}

		#endregion

		private void niTray_Click(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void tiClose_Tick(object sender, EventArgs e)
		{
			tiClose.Stop();
			Close();
		}

		private void lbLog_Click(object sender, EventArgs e)
		{
			if (lbLog.SelectedIndex > -1)
			{
				tbLog.Text = lbLog.Items[lbLog.SelectedIndex].ToString();
			}
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized == this.WindowState)
			{
				niTray.Visible = true;
				this.Hide();
			}

			else
			{
				niTray.Visible = false;
			}
		}

		private void tiHideOnStart_Tick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			tiHideOnStart.Stop();
		}

		private void HrParserOnValueChanged(object sender, RateChangedEventArgs e)
		{
			if (!_heartRateMonitor.IsConnected)
				return;
			try
			{
				this.Invoke((MethodInvoker)delegate
				{
					if (cbTestMode.Checked)
						lastBpm = 60;
					else
						lastBpm = e.BeatsPerMinute;
					this.Text = String.Format("{1} bpm | AtPulso by GoodVrGames v{0}", version, lastBpm);
				});
			}
			catch (Exception ex) { 
				Log(ex.Message); 
			}
		}

		private async void HrDeviceOnDeviceConnectionStatusChanged(object sender, ConnectionStatusChangedEventArgs e)
		{
			if (e.IsConnected)
			{
				try
				{
					var device = await _heartRateMonitor.GetDeviceInfoAsync();
					this.Invoke((MethodInvoker)delegate
					{
						if (tbDeviceStatus.Text != "Connected")
							Log("Connected");
						tbDeviceName.Text = device.Name;
						tbDeviceStatus.Text = "Connected";
						tbDeviceBattery.Text = String.Format("{0}%", device.BatteryPercent);

						cbTestMode.Enabled = true;
						connectToolStripMenuItem.Enabled = false;
						getDeviceInfoToolStripMenuItem.Enabled = true;
						disconnectToolStripMenuItem.Enabled = true;


						if (bool.Parse(Properties.Settings.Default.AutoStartServerWhenConnected))
						{
							StartServer();
						}
					});
				}
				catch (Exception ex)
				{
					Log(ex.Message);
				}
			}
			else
			{
				this.Invoke((MethodInvoker)delegate {
					tbDeviceStatus.Text = "Disconnected";
					tbDeviceBattery.Text = "--";
					this.Text = "AtPulso by GoodVrGames";
					Log("Disconnected");

					cbTestMode.Checked = false;
					cbTestMode.Enabled = false;
					connectToolStripMenuItem.Enabled = true;
					getDeviceInfoToolStripMenuItem.Enabled = false;
					disconnectToolStripMenuItem.Enabled = false;
					if (!disconnectedByButton && !bool.Parse(Properties.Settings.Default.RetryConnectWhenFailed))
						PlaySoundAlert();
				});
				if (bool.Parse(Properties.Settings.Default.RetryConnectWhenFailed))
				{
					if (disconnectedByButton)
					{
						disconnectedByButton = false;
						return;
					}
					Log("Try to Reconnect");
					ConnectToBt();
					return;
				}
			}
		}

		private async void ConnectToBt(int tryNow = 0)
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.BleDeviceId))
			{
				Log("Device Id is empty");
				return;
			}

			if (_heartRateMonitor.IsConnected)
			{
				try
				{
					await _heartRateMonitor.DisconnectAsync();
				}
				catch (Exception ex)
				{
					Log(ex.Message);
				}
			}
			try
			{
				var connectResult = await _heartRateMonitor.ConnectAsync(Properties.Settings.Default.BleDeviceId);
				if (!connectResult.IsConnected)
				{
					Log(connectResult.ErrorMessage);
					this.Invoke((MethodInvoker)delegate
					{
						tbDeviceStatus.Text = "Error";
						if (bool.Parse(Properties.Settings.Default.RetryConnectWhenFailed))
						{
							if (tryNow > 3)
							{
								Properties.Settings.Default.BleDeviceId = "";
								Properties.Settings.Default.AutoConnectAtStart = false.ToString();
								Properties.Settings.Default.Save();
								cbAutoConnectAtStart.Checked = false;
								tbDeviceId.Text = "";
								Log("Stop trying to Reconnect after 5 times");
								PlaySoundAlert();
								return;
							}

							Log("Try to Reconnect");
							ConnectToBt(tryNow + 1);
							return;
						}
						else
						{
							Properties.Settings.Default.BleDeviceId = "";
							Properties.Settings.Default.Save();
							tbDeviceId.Text = "";
							PlaySoundAlert();
						}
					});
				}
			}
			catch (Exception ex) {
				Log(ex.Message); 
			}
		}

		private void StartServer()
		{
			if (serverStarted)
				return;
			serverStarted = true;

			var port = Properties.Settings.Default.ServerPort.ToString();
			string prefix = "http://localhost:" + port + "/";
			string prefix2 = "http://localhost:" + port + "/getpulse/";

			serverListener.Prefixes.Clear();

			serverListener.Prefixes.Add(prefix);
			serverListener.Prefixes.Add(prefix2);
			Log("Listening: " + prefix);
			tbServerAddress.Text = prefix;
			serverListener.Start();

			tokenSource = new CancellationTokenSource();
			serverStopToken = tokenSource.Token;

			Task.Run(() => {
				this.Invoke((MethodInvoker) delegate
				{
					startToolStripMenuItem.Enabled = false;
					stopToolStripMenuItem.Enabled = true;
					if (bool.Parse(Properties.Settings.Default.PreviewAutostart))
					{
						ShowPreview();
					}
				});
				while (!serverStopToken.IsCancellationRequested)
					ListeningServer();
				serverStarted = false;
				serverListener.Stop();
				Log("Stop at: " + prefix);
				this.Invoke((MethodInvoker)delegate
				{
					startToolStripMenuItem.Enabled = true;
					stopToolStripMenuItem.Enabled = false;
				});
			}, serverStopToken);
		}

		private void StopServer()
		{
			tokenSource.Cancel();
			tbServerAddress.Text = "";
		}

		private void ListeningServer()
		{
			try
			{
				HttpListenerContext context = serverListener.GetContextAsync().AsCancellable(serverStopToken).Result;
				HttpListenerRequest request = context.Request;
				HttpListenerResponse response = context.Response;
				System.IO.Stream output = response.OutputStream;
				if (request.Url.ToString().Contains("getpulse"))
				{
					// get pulse
					string responseString = lastBpm.ToString();
					byte[] buffer = Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					output.Write(buffer, 0, buffer.Length);
				}
				else if (request.Url.ToString().Contains("chartjs"))
				{
					// js
					string responseString = Properties.Resources.Chartjs;
					byte[] buffer = Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					output.Write(buffer, 0, buffer.Length);
				}
				else if (request.Url.ToString().Contains("video"))
				{
					// anim
					byte[] buffer = System.IO.File.ReadAllBytes(Properties.Settings.Default.AnimationPath);
					response.ContentLength64 = buffer.Length;
					output.Write(buffer, 0, buffer.Length);
				}
				else if (request.Url.ToString().Contains("css"))
				{
					// css
					string responseString = Properties.Resources.Css;
					byte[] buffer = Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					output.Write(buffer, 0, buffer.Length);
				}
				else
				{
					// other
					string responseString = Properties.Resources.MainPage;

					responseString = responseString.Replace("{style_header}", Properties.Resources.Css);
					if (int.Parse(Properties.Settings.Default.OutputOrientation) == 0)
					{
						switch (int.Parse(Properties.Settings.Default.OutputMode))
						{
							case 0: // All
								responseString = responseString.Replace("{chart_header}", Properties.Resources.ChartJsHeader);
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.ChartJsContainer +
									Properties.Resources.HR +
									Properties.Resources.Animation
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_All);
								responseString = responseString.Replace("{left_big_number}", Properties.Settings.Default.ChartWidth);
								responseString = responseString.Replace("{video_left}", (int.Parse(Properties.Settings.Default.ChartWidth) + 150).ToString());
								break;
							case 1: // Chart + HR
								responseString = responseString.Replace("{chart_header}", Properties.Resources.ChartJsHeader);
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.ChartJsContainer +
									Properties.Resources.HR
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_Chart_HR);
								responseString = responseString.Replace("{left_big_number}", Properties.Settings.Default.ChartWidth.ToString());
								break;
							case 2: // HR + Anim
								responseString = responseString.Replace("{chart_header}", "");
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.HR +
									Properties.Resources.Animation
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_HR_Anim);
								responseString = responseString.Replace("{left_big_number}", "0");
								responseString = responseString.Replace("{video_left}", "150");
								break;
							case 3: // HR only
								responseString = responseString.Replace("{chart_header}", "");
								responseString = responseString.Replace("{main_container}",	Properties.Resources.HR);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_HR);
								responseString = responseString.Replace("{left_big_number}", "0");
								break;
						}
						responseString = responseString.Replace("{position_small_numbers}", "right");
						responseString = responseString.Replace("{container_left}", "0");						
					} 
					else
					{
						switch (int.Parse(Properties.Settings.Default.OutputMode))
						{
							case 0: // All
								responseString = responseString.Replace("{chart_header}", Properties.Resources.ChartJsHeader);
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.Animation +
									Properties.Resources.HR +
									Properties.Resources.ChartJsContainer
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_All);
								responseString = responseString.Replace("{container_left}", "250");
								responseString = responseString.Replace("{left_big_number}", "150");
								responseString = responseString.Replace("{video_left}", "0");
								break;
							case 1: // Chart + HR
								responseString = responseString.Replace("{chart_header}", Properties.Resources.ChartJsHeader);
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.HR +
									Properties.Resources.ChartJsContainer
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_Chart_HR);
								responseString = responseString.Replace("{container_left}", "150");
								responseString = responseString.Replace("{left_big_number}", "0");
								break;
							case 2: // HR + Anim
								responseString = responseString.Replace("{chart_header}", "");
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.Animation +
									Properties.Resources.HR
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_HR_Anim);
								responseString = responseString.Replace("{left_big_number}", "150");
								responseString = responseString.Replace("{video_left}", "0");
								break;
							case 3: // HR only
								responseString = responseString.Replace("{chart_header}", "");
								responseString = responseString.Replace("{main_container}", Properties.Resources.HR);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_HR);
								responseString = responseString.Replace("{left_big_number}", "0");
								break;
						}
						responseString = responseString.Replace("{position_small_numbers}", "left");
					}


					responseString = responseString.Replace("{port}", Properties.Settings.Default.ServerPort);
					responseString = responseString.Replace("{font_family}", Properties.Settings.Default.FontFamily);
					responseString = responseString.Replace("{dots_width}", Properties.Settings.Default.ChartDotsCount);
					responseString = responseString.Replace("{color_line}", Properties.Settings.Default.LineColor);
					responseString = responseString.Replace("{color_big_number}", Properties.Settings.Default.HeartRateColor);
					responseString = responseString.Replace("{color_small_numbers}", Properties.Settings.Default.MinMaxColor);
					responseString = responseString.Replace("{animation_filter}", Properties.Settings.Default.AnimationFilter);
					//responseString = responseString.Replace("{display_mode_big_number}", showBigNumber ? "inline-block" : "none");
					responseString = responseString.Replace("{chart_width}", Properties.Settings.Default.ChartWidth);
					responseString = responseString.Replace("{line_thickness}", Properties.Settings.Default.ChartLineThickness);
					responseString = responseString.Replace("{anim_speed_multiplier}", Properties.Settings.Default.AnimationSpeedMultiplier.Replace(",", "."));
					responseString = responseString.Replace("{line_smooth}", bool.Parse(Properties.Settings.Default.ChartLineSmooth) ? "0.4" : "0");

					responseString = responseString.Replace("{hr_threshold_change}", bool.Parse(Properties.Settings.Default.HeartRateThresholdChange) ? "true" : "false");
					responseString = responseString.Replace("{hr_threshold}", Properties.Settings.Default.HeartRateThreshold.ToString());
					responseString = responseString.Replace("{hr_threshold_color}", Properties.Settings.Default.HeartRateThresholdColor);

					responseString = responseString.Replace("{hr_style}", Properties.Settings.Default.HeartRateStyle);
					responseString = responseString.Replace("{hr_fontsize}", Properties.Settings.Default.HeartRateFontSize);
					responseString = responseString.Replace("{hr_fontbottom}", (75 + int.Parse(Properties.Settings.Default.HeartRateFontSize)/2 - int.Parse(Properties.Settings.Default.HeartRateFontSize)/10).ToString());


					byte[] buffer = Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					output.Write(buffer, 0, buffer.Length);
				}
				output.Close();
				response.Close();
			}
			catch { }
		}

		private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (serverStarted)
			{
				StopServer();
				e.Cancel = true;
			}
			if (_heartRateMonitor.IsConnected)
			{
				disconnectedByButton = true;
				if (_heartRateMonitor.IsConnected)
					await _heartRateMonitor.DisconnectAsync();
				e.Cancel = true;
			}
			if (e.Cancel)
			{
				tiClose.Start();
			}
		}

		void PlaySoundAlert()
		{
			try
			{
				if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
					return;
				if (!System.IO.File.Exists("Disconnected.mp3"))
				{
					System.IO.File.WriteAllBytes("Disconnected.mp3", Properties.Resources.Disconnected);
				}
				wplayer.URL = "Disconnected.mp3";
				wplayer.controls.play();
			}
			catch (Exception ex)
			{
				Log(ex.Message);
			}
		}

		private void ShowPreview()
		{
			if (!serverStarted || string.IsNullOrEmpty(tbServerAddress.Text))
			{
				MessageBox.Show("You must start server first!", "AtPulso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			fp.address = tbServerAddress.Text;
			if (fp.Visible == false)
				fp.Show();
			else
				fp.UpdateWidth();
		}

		#region UI_Menu

		private void exportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "*.json|*.json";
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					var propertyMap = new Dictionary<string, object>();
					foreach (var propertyInfo in Properties.Settings.Default.GetType().GetProperties())
					{
						if (propertyInfo.CanRead && propertyInfo.CanWrite && propertyInfo.GetCustomAttributes(typeof(UserScopedSettingAttribute), false).Any())
						{
							var name = propertyInfo.Name;
							var value = propertyInfo.GetValue(Properties.Settings.Default, null);
							propertyMap.Add(name, value);
						}
					}

					string jsonString = JsonConvert.SerializeObject(propertyMap);

					System.IO.File.WriteAllText(sfd.FileName, jsonString);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "AtPulso - Export Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void importSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.Filter = "*.json|*.json";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string jsonString = System.IO.File.ReadAllText(ofd.FileName);
					var propertyMap = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);


					foreach (var propertyInfo in Properties.Settings.Default.GetType().GetProperties())
					{
						if (propertyInfo.CanRead && propertyInfo.CanWrite && propertyInfo.GetCustomAttributes(typeof(UserScopedSettingAttribute), false).Any())
						{
							try
							{
								var value = propertyMap[propertyInfo.Name];
								propertyInfo.SetValue(Properties.Settings.Default, value, null);
							}
							catch { }
						}
					}
					Properties.Settings.Default.Save();
					UpdateUiBySettings();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "AtPulso - Import Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSelectDevice formSelectDevice = new FormSelectDevice();
			if (formSelectDevice.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.BleDeviceId = formSelectDevice.selectedDeviceId;
				Properties.Settings.Default.Save();
				tbDeviceId.Text = Properties.Settings.Default.BleDeviceId;
				ConnectToBt();
			}
		}

		private async void getDeviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var device = await _heartRateMonitor.GetDeviceInfoAsync();
				this.Invoke((MethodInvoker)delegate
				{
					Log("Firmware: " + device.Firmware);
					Log("Hardware: " + device.Hardware);
					Log("S/N: " + device.SerialNumber);
					Log("Model: " + device.ModelNumber);
					Log("Manufacturer: " + device.Manufacturer);

					tbDeviceName.Text = device.Name;
					tbDeviceStatus.Text = "Connected";
					tbDeviceBattery.Text = String.Format("{0}%", device.BatteryPercent);
				});
			}
			catch (Exception ex)
			{
				Log(ex.Message);
			}
		}

		private async void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StopServer();
			tbDeviceId.Text = "";
			disconnectedByButton = true;
			if (_heartRateMonitor.IsConnected)
				await _heartRateMonitor.DisconnectAsync();
			Properties.Settings.Default.BleDeviceId = "";
			Properties.Settings.Default.Save();
		}

		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StartServer();
		}

		private void stopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StopServer();
		}

		private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/alextrof94/AtPulso/");
		}

		private void myTwitchChannelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.twitch.tv/goodvrgames");
		}

		private void addSuggestionsOrIssueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/alextrof94/AtPulso/issues/new");
		}
		#endregion

		private void showPreviewWindowToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			ShowPreview();
		}
	}
}
