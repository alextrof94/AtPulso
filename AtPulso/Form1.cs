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
		private string version = "1.5.2";

		public ObservableCollection<WatcherDevice> Devices = new ObservableCollection<WatcherDevice>();
		private HeartRateMonitor HrMonitor = new HeartRateMonitor();
		private bool BtIsConnected = false;


        private int LastBpm = 0;

		HttpListener ServerListener = new HttpListener();
		bool ServerStarted = false;
		CancellationTokenSource TokenSource;
		CancellationToken ServerStopToken;

		bool DisconnectedByButton = false;

		WMPLib.WindowsMediaPlayer Wplayer = new WMPLib.WindowsMediaPlayer();
		FormPreview Fp = new FormPreview();

		public Form1()
		{
			InitializeComponent();
			Fp.parent = this;
		}

		private void Log(string str)
		{
			try
			{
				LbLog.Invoke((MethodInvoker)delegate
				{
					LbLog.Items.Insert(0, str);
				});
			} catch { }
		} 

		private void RecalculateObsWidth()
		{
			int width = 0;
			switch (CbOutputMode.SelectedIndex)
			{
				case 0: width = (int)NudChartWidth.Value + 150 + 150; break; // All
				case 1: width = (int)NudChartWidth.Value + 150; break; // Chart + HR
				case 2: width = 150 + 150; break; // HR + Anim
				case 3: width = 150; break; // HR
			}
			TbObsWidth.Text = width.ToString();
			Fp.width = width;
		}

		private string SelectColor(TextBox tb, PictureBox pb, string old)
		{
			if (cdSelectColor.ShowDialog() == DialogResult.OK)
			{
				byte[] input = new byte[] { cdSelectColor.Color.R, cdSelectColor.Color.G, cdSelectColor.Color.B };
				string output = "#" + BitConverter.ToString(input).Replace("-", "");
				tb.Text = output;
				pb.BackColor = cdSelectColor.Color;
				return output;
			}
			return old;
		}

		private void LoadColor(TextBox tb, PictureBox pb, string color)
		{
			tb.Text = color;
			var colorHex = "FF" + color.Substring(1);
			var col = Color.FromArgb(int.Parse(colorHex, System.Globalization.NumberStyles.HexNumber));
			pb.BackColor = col;
		}

		private void UpdateUiBySettings()
		{
			try
			{
				CbAutoConnectAtStart.Checked = Properties.Settings.Default.AutoConnectAtStart;
				CbHideAtStart.Checked = Properties.Settings.Default.HideAtStart;
				CbRetryConnect.Checked = Properties.Settings.Default.RetryConnectWhenFailed;
				CbServerAutostart.Checked = Properties.Settings.Default.AutoStartServerWhenConnected;
				CbSoundAlert.Checked = Properties.Settings.Default.SoundAlert;
				CbAutoShowPreview.Checked = Properties.Settings.Default.PreviewAutostart;
                TbVolume.Value = Properties.Settings.Default.SoundAlertVolume;

                TbDeviceId.Text = Properties.Settings.Default.BleDeviceId;

				NudServerPort.Value = Properties.Settings.Default.ServerPort;

				CbOutputMode.SelectedIndex = Properties.Settings.Default.OutputMode;
				CbOutputOrientation.SelectedIndex = Properties.Settings.Default.OutputOrientation;
				TbFontFamily.Text = Properties.Settings.Default.FontFamily;

				LoadColor(TbHeartRateColor, PbHeartRateColor, Properties.Settings.Default.HeartRateColor);
				NudHeartRateFontSize.Value = Properties.Settings.Default.HeartRateFontSize;
				LoadColor(TbHeartRateThresholdColor, PbHeartRateThresholdColor, Properties.Settings.Default.HeartRateThresholdColor);
				CbHeartRateThresholdChange.Checked = Properties.Settings.Default.HeartRateThresholdChange;
				NudHeartRateThreshold.Value = Properties.Settings.Default.HeartRateThreshold;
				switch (Properties.Settings.Default.HeartRateStyle)
				{
					case "glow": CbHeartRateOutlineStyle.SelectedIndex = 1; break;
					case "black_border": CbHeartRateOutlineStyle.SelectedIndex = 2; break;
					case "white_border": CbHeartRateOutlineStyle.SelectedIndex = 3; break;
					default: CbHeartRateOutlineStyle.SelectedIndex = 0; break;
				}

				NudChartDotsCount.Value = Properties.Settings.Default.ChartDotsCount;
				NudChartWidth.Value = Properties.Settings.Default.ChartWidth;
				LoadColor(TbLineColor, PbLineColor, Properties.Settings.Default.LineColor);
				LoadColor(TbMinMaxColor, PbMinMaxColor, Properties.Settings.Default.MinMaxColor);
				NudChartLineThickness.Value = Properties.Settings.Default.ChartLineThickness;
				CbChartLineSmooth.Checked = Properties.Settings.Default.ChartLineSmooth;

				TbAnimationPath.Text = Properties.Settings.Default.AnimationPath;
				NudAnimSpeedMultiplier.Value = Properties.Settings.Default.AnimationSpeedMultiplier;
				TbAnimFilter.Text = Properties.Settings.Default.AnimationFilter;

				Fp.bgIndex = int.Parse(Properties.Settings.Default.PreviewBackgroundColor);
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
			HrMonitor.ConnectionStatusChanged += HrDeviceOnDeviceConnectionStatusChanged;

            //// we can create value parser and listen for parsed values of given characteristic
            //HrParser.ConnectWithCharacteristic(HrDevice.HeartRate.HeartRateMeasurement);
            //_heartRateMonitor.RateChanged -= HrParserOnValueChanged;
            HrMonitor.RateChanged += HrParserOnValueChanged;

			if (Properties.Settings.Default.AutoConnectAtStart)
			{
				if (!string.IsNullOrEmpty(Properties.Settings.Default.BleDeviceId))
				{
					ConnectToBt();
					if (Properties.Settings.Default.HideAtStart)
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

		private void CbHideAtStart_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HideAtStart = CbHideAtStart.Checked;
			Properties.Settings.Default.Save();
		}

		private void CbAutoConnectAndHide_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoConnectAtStart = CbAutoConnectAtStart.Checked;
			Properties.Settings.Default.Save();
		}

		private void CbRetryConnect_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.RetryConnectWhenFailed = CbRetryConnect.Checked;
			Properties.Settings.Default.Save();
		}

		private void CbServerAutostart_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoStartServerWhenConnected = CbServerAutostart.Checked;
			Properties.Settings.Default.Save();
		}

		private void CbAutoShowPreview_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.PreviewAutostart = CbAutoShowPreview.Checked;
			Properties.Settings.Default.Save();
		}

		private void CbSoundAlert_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.SoundAlert = CbSoundAlert.Checked;
			Properties.Settings.Default.Save();
        }

        private void TbVolume_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.SoundAlertVolume = TbVolume.Value;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region UIServerSettings

        private void NudServerPort_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ServerPort = (int)NudServerPort.Value;
			Properties.Settings.Default.Save();
		}

		#endregion

		#region UIOutputSettings

		private void CbOutputMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OutputMode = CbOutputMode.SelectedIndex;
			Properties.Settings.Default.Save();
			RecalculateObsWidth();
			switch (CbOutputMode.SelectedIndex)
			{
				case 0: TabChart.Enabled = true;  TabHeartRate.Enabled = true; TabAnimation.Enabled = true; break; // All
				case 1: TabChart.Enabled = true;  TabHeartRate.Enabled = true; TabAnimation.Enabled = false; break; // Chart + HR
				case 2: TabChart.Enabled = false; TabHeartRate.Enabled = true; TabAnimation.Enabled = true; break; // HR + Anim
				case 3: TabChart.Enabled = false; TabHeartRate.Enabled = true; TabAnimation.Enabled = false; break; // HR
			}
		}

        private void cbOutputOrientation_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OutputOrientation = CbOutputOrientation.SelectedIndex;
			Properties.Settings.Default.Save();
		}

		bool tbFontFamily_TextChangedByCode = false;
		private void TbFontFamily_TextChanged(object sender, EventArgs e)
		{
			if (tbFontFamily_TextChangedByCode)
			{
				tbFontFamily_TextChangedByCode = false;
				return;
			}
			if (string.IsNullOrEmpty(TbFontFamily.Text))
			{
				tbFontFamily_TextChangedByCode = true;
				TbFontFamily.Text = "cursive";
			}
			TbFontFamily.Text = TbFontFamily.Text.Replace("\"", "'");
			Properties.Settings.Default.FontFamily = TbFontFamily.Text;
			Properties.Settings.Default.Save();
		}

		private void BuOpenCssFontPage_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.w3schools.com/css/css_font.asp");
		}


		private void NudChartDotsCount_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartDotsCount = (int)NudChartDotsCount.Value;
			Properties.Settings.Default.Save();
		}

		private void NudChartWidth_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartWidth = (int)NudChartWidth.Value;
			Properties.Settings.Default.Save();
			RecalculateObsWidth();
		}

		private void BuLineColor_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.LineColor = SelectColor(TbLineColor, PbLineColor, Properties.Settings.Default.LineColor);
			Properties.Settings.Default.Save();
		}

		private void BuMinMaxColor_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.MinMaxColor = SelectColor(TbMinMaxColor, PbMinMaxColor, Properties.Settings.Default.MinMaxColor);
			Properties.Settings.Default.Save();
		}

		private void NudChartLineWidth_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartLineThickness = (int)NudChartLineThickness.Value;
			Properties.Settings.Default.Save();
		}

		private void CbChartLineSmooth_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartLineSmooth = CbChartLineSmooth.Checked;
			Properties.Settings.Default.Save();
		}

		private void BuHeartRateColor_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateColor = SelectColor(TbHeartRateColor, PbHeartRateColor, Properties.Settings.Default.HeartRateColor);
			Properties.Settings.Default.Save();
		}

		private void CbHeartRateOutlineStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (CbHeartRateOutlineStyle.SelectedIndex)
			{
				case 1: Properties.Settings.Default.HeartRateStyle = "glow"; break;
				case 2: Properties.Settings.Default.HeartRateStyle = "black_border"; break;
				case 3: Properties.Settings.Default.HeartRateStyle = "white_border"; break;
				default: Properties.Settings.Default.HeartRateStyle = ""; break;
			}
			Properties.Settings.Default.Save();
		}

		private void NudFontSize_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateFontSize = (int)NudHeartRateFontSize.Value;
			Properties.Settings.Default.Save();
		}

		private void CbHeartRateThresholdChange_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateThresholdChange = CbHeartRateThresholdChange.Checked;
			Properties.Settings.Default.Save();
		}

		private void NudHeartRateThreshold_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateThreshold = (int)NudHeartRateThreshold.Value;
			Properties.Settings.Default.Save();
		}

		private void BuHeartRateThresholdColor_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.HeartRateThresholdColor = SelectColor(TbHeartRateThresholdColor, PbHeartRateThresholdColor, Properties.Settings.Default.HeartRateThresholdColor);
			Properties.Settings.Default.Save();
		}


		private void BuAnimationSelect_Click(object sender, EventArgs e)
		{
			if (ofdSelectAnimation.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.AnimationPath = ofdSelectAnimation.FileName;
				Properties.Settings.Default.Save();
				TbAnimationPath.Text = ofdSelectAnimation.FileName;
			}
		}

		private void BuAnimationClear_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationPath = "";
			Properties.Settings.Default.Save();
			TbAnimationPath.Text = "";
		}

		private void NudAnimSpeedMultiplier_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationSpeedMultiplier = NudAnimSpeedMultiplier.Value;
			Properties.Settings.Default.Save();
		}

		private void TbAnimFilter_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationFilter = TbAnimFilter.Text;
			Properties.Settings.Default.Save();
		}

		private void BuOpenFilterPage_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://codepen.io/sosuke/pen/Pjoqqp");
		}

		#endregion

		private void NiTray_Click(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void TiClose_Tick(object sender, EventArgs e)
		{
			tiClose.Stop();
			Close();
		}

		private void LbLog_Click(object sender, EventArgs e)
		{
			if (LbLog.SelectedIndex > -1)
			{
				TbLog.Text = LbLog.Items[LbLog.SelectedIndex].ToString();
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

		private void TiHideOnStart_Tick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			tiHideOnStart.Stop();
		}

		private void HrParserOnValueChanged(object sender, RateChangedEventArgs e)
		{
			if (!BtIsConnected)
				return;
			try
			{
				this.Invoke((MethodInvoker)delegate
				{
					if (cbTestMode.Checked)
						LastBpm = 60;
					else
						LastBpm = e.BeatsPerMinute;
					this.Text = String.Format("{1} bpm | AtPulso by GoodVrGames v{0}", version, LastBpm);
				});
			}
			catch (Exception ex) { 
				Log(ex.Message); 
			}
		}

		private async void HrDeviceOnDeviceConnectionStatusChanged(object sender, ConnectionStatusChangedEventArgs e)
		{
			bool newIsConnected = e.IsConnected;
            if (newIsConnected && !BtIsConnected)
			{
                BtIsConnected = true;
                try
				{
					var device = await HrMonitor.GetDeviceInfoAsync();
					this.Invoke((MethodInvoker)delegate
					{
						if (TbDeviceStatus.Text != "Connected")
							Log("Connected");
						TbDeviceName.Text = device.Name;
						TbDeviceStatus.Text = "Connected";
						TbDeviceBattery.Text = String.Format("{0}%", device.BatteryPercent);

						cbTestMode.Enabled = true;
						connectToolStripMenuItem.Enabled = false;
						getDeviceInfoToolStripMenuItem.Enabled = true;
						disconnectToolStripMenuItem.Enabled = true;


						if (Properties.Settings.Default.AutoStartServerWhenConnected)
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
			else if (!newIsConnected && BtIsConnected)
			{
                BtIsConnected = false;
                this.Invoke((MethodInvoker)delegate {
					TbDeviceStatus.Text = "Disconnected";
					TbDeviceBattery.Text = "--";
					this.Text = "AtPulso by GoodVrGames";
					Log("Disconnected");

					cbTestMode.Checked = false;
					cbTestMode.Enabled = false;
					connectToolStripMenuItem.Enabled = true;
					getDeviceInfoToolStripMenuItem.Enabled = false;
					disconnectToolStripMenuItem.Enabled = false;
					if (!DisconnectedByButton && !Properties.Settings.Default.RetryConnectWhenFailed)
						PlaySoundAlert();
				});
				if (Properties.Settings.Default.RetryConnectWhenFailed)
				{
					if (DisconnectedByButton)
					{
						DisconnectedByButton = false;
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

			if (BtIsConnected)
			{
				try
				{
					await HrMonitor.DisconnectAsync();
				}
				catch (Exception ex)
				{
					Log(ex.Message);
				}
			}
			try
			{
				var connectResult = await HrMonitor.ConnectAsync(Properties.Settings.Default.BleDeviceId);
				if (!connectResult.IsConnected)
				{
					Log(connectResult.ErrorMessage);
					this.Invoke((MethodInvoker)delegate
					{
						TbDeviceStatus.Text = "Error";
						if (Properties.Settings.Default.RetryConnectWhenFailed)
						{
							if (tryNow > 3)
							{
								Properties.Settings.Default.BleDeviceId = "";
								Properties.Settings.Default.AutoConnectAtStart = false;
								Properties.Settings.Default.Save();
								CbAutoConnectAtStart.Checked = false;
								TbDeviceId.Text = "";
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
							TbDeviceId.Text = "";
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
			if (ServerStarted)
				return;
			ServerStarted = true;

			var port = Properties.Settings.Default.ServerPort.ToString();
			string prefix = "http://localhost:" + port + "/";
			string prefix2 = "http://localhost:" + port + "/getpulse/";

			ServerListener.Prefixes.Clear();

			ServerListener.Prefixes.Add(prefix);
			ServerListener.Prefixes.Add(prefix2);
			Log("Listening: " + prefix);
			TbServerAddress.Text = prefix;
			ServerListener.Start();

			TokenSource = new CancellationTokenSource();
			ServerStopToken = TokenSource.Token;

			Task.Run(() => {
				this.Invoke((MethodInvoker) delegate
				{
					startToolStripMenuItem.Enabled = false;
					stopToolStripMenuItem.Enabled = true;
					if (Properties.Settings.Default.PreviewAutostart)
					{
						ShowPreview();
					}
				});
				while (!ServerStopToken.IsCancellationRequested)
					ListeningServer();
				ServerStarted = false;
				ServerListener.Stop();
				Log("Stop at: " + prefix);
				this.Invoke((MethodInvoker)delegate
				{
					startToolStripMenuItem.Enabled = true;
					stopToolStripMenuItem.Enabled = false;
				});
			}, ServerStopToken);
		}

		private void StopServer()
		{
			TokenSource.Cancel();
			TbServerAddress.Text = "";
		}

		private void ListeningServer()
		{
			try
			{
				HttpListenerContext context = ServerListener.GetContextAsync().AsCancellable(ServerStopToken).Result;
				HttpListenerRequest request = context.Request;
				HttpListenerResponse response = context.Response;
				System.IO.Stream output = response.OutputStream;
				if (request.Url.ToString().Contains("getpulse"))
				{
					// get pulse
					string responseString = LastBpm.ToString();
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
					if (Properties.Settings.Default.OutputOrientation == 0)
					{
						switch (Properties.Settings.Default.OutputMode)
						{
							case 0: // All
								responseString = responseString.Replace("{chart_header}", Properties.Resources.ChartJsHeader);
								responseString = responseString.Replace("{main_container}",
									Properties.Resources.ChartJsContainer +
									Properties.Resources.HR +
									Properties.Resources.Animation
									);
								responseString = responseString.Replace("{script_footer}", Properties.Resources.Footer_All);
								responseString = responseString.Replace("{left_big_number}", Properties.Settings.Default.ChartWidth.ToString());
								responseString = responseString.Replace("{video_left}", (Properties.Settings.Default.ChartWidth + 150).ToString());
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
						switch (Properties.Settings.Default.OutputMode)
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


					responseString = responseString.Replace("{port}", Properties.Settings.Default.ServerPort.ToString());
					responseString = responseString.Replace("{font_family}", Properties.Settings.Default.FontFamily);
					responseString = responseString.Replace("{dots_width}", Properties.Settings.Default.ChartDotsCount.ToString());
					responseString = responseString.Replace("{color_line}", Properties.Settings.Default.LineColor);
					responseString = responseString.Replace("{color_big_number}", Properties.Settings.Default.HeartRateColor);
					responseString = responseString.Replace("{color_small_numbers}", Properties.Settings.Default.MinMaxColor);
					responseString = responseString.Replace("{animation_filter}", Properties.Settings.Default.AnimationFilter);
					//responseString = responseString.Replace("{display_mode_big_number}", showBigNumber ? "inline-block" : "none");
					responseString = responseString.Replace("{chart_width}", Properties.Settings.Default.ChartWidth.ToString());
					responseString = responseString.Replace("{line_thickness}", Properties.Settings.Default.ChartLineThickness.ToString());
					responseString = responseString.Replace("{anim_speed_multiplier}", Properties.Settings.Default.AnimationSpeedMultiplier.ToString());
					responseString = responseString.Replace("{line_smooth}", Properties.Settings.Default.ChartLineSmooth ? "0.4" : "0");

					responseString = responseString.Replace("{hr_threshold_change}", Properties.Settings.Default.HeartRateThresholdChange ? "true" : "false");
					responseString = responseString.Replace("{hr_threshold}", Properties.Settings.Default.HeartRateThreshold.ToString());
					responseString = responseString.Replace("{hr_threshold_color}", Properties.Settings.Default.HeartRateThresholdColor);

					responseString = responseString.Replace("{hr_style}", Properties.Settings.Default.HeartRateStyle);
					responseString = responseString.Replace("{hr_fontsize}", Properties.Settings.Default.HeartRateFontSize.ToString());
					responseString = responseString.Replace("{hr_fontbottom}", (75 + Properties.Settings.Default.HeartRateFontSize/2 - Properties.Settings.Default.HeartRateFontSize /10).ToString());


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
			if (ServerStarted)
			{
				StopServer();
				e.Cancel = true;
			}
			if (BtIsConnected)
			{
				DisconnectedByButton = true;
				if (BtIsConnected)
					await HrMonitor.DisconnectAsync();
				e.Cancel = true;
			}
			if (e.Cancel)
			{
				tiClose.Start();
			}
		}

		void PlaySoundAlert()
		{
			if (!Properties.Settings.Default.SoundAlert) return;
			try
			{
				if (Wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
					return;
				if (!System.IO.File.Exists("Disconnected.mp3"))
				{
					System.IO.File.WriteAllBytes("Disconnected.mp3", Properties.Resources.Disconnected);
				}
				Wplayer.URL = "Disconnected.mp3";
				Wplayer.settings.volume = Properties.Settings.Default.SoundAlertVolume;
				Wplayer.controls.play();
			}
			catch (Exception ex)
			{
				Log(ex.Message);
			}
		}

		private void ShowPreview()
		{
			if (!ServerStarted || string.IsNullOrEmpty(TbServerAddress.Text))
			{
				MessageBox.Show("You must start server first!", "AtPulso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			Fp.address = TbServerAddress.Text;
			if (Fp.Visible == false)
				Fp.Show();
			else
				Fp.UpdateWidth();
		}

		#region UI_Menu

		private void ExportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void ImportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSelectDevice formSelectDevice = new FormSelectDevice();
			if (formSelectDevice.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.BleDeviceId = formSelectDevice.selectedDeviceId;
				Properties.Settings.Default.Save();
				TbDeviceId.Text = Properties.Settings.Default.BleDeviceId;
				ConnectToBt();
			}
		}

		private async void GetDeviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var device = await HrMonitor.GetDeviceInfoAsync();
				this.Invoke((MethodInvoker)delegate
				{
					Log("Firmware: " + device.Firmware);
					Log("Hardware: " + device.Hardware);
					Log("S/N: " + device.SerialNumber);
					Log("Model: " + device.ModelNumber);
					Log("Manufacturer: " + device.Manufacturer);

					TbDeviceName.Text = device.Name;
					TbDeviceStatus.Text = "Connected";
					TbDeviceBattery.Text = String.Format("{0}%", device.BatteryPercent);
				});
			}
			catch (Exception ex)
			{
				Log(ex.Message);
			}
		}

		private async void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StopServer();
			TbDeviceId.Text = "";
			DisconnectedByButton = true;
			if (BtIsConnected)
				await HrMonitor.DisconnectAsync();
			Properties.Settings.Default.BleDeviceId = "";
			Properties.Settings.Default.Save();
		}

		private void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StartServer();
		}

		private void StopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StopServer();
		}

		private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/alextrof94/AtPulso/");
		}

		private void MyTwitchChannelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.twitch.tv/goodvrgames");
		}

		private void AddSuggestionsOrIssueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/alextrof94/AtPulso/issues/new");
		}
		#endregion

		private void ShowPreviewWindowToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			ShowPreview();
		}

        List<double> CalculateMovingAverage(List<double> data, int windowSize)
        {
            List<double> movingAverages = new List<double>();

            for (int i = 0; i <= data.Count - windowSize; i++)
            {
                double average = data.Skip(i).Take(windowSize).Average();
                movingAverages.Add(average);
            }

            return movingAverages;
        }

        DateTime prevClick;
		List<TimeSpan> timespans = new List<TimeSpan>();
        List<double> valuesForAvg = new List<double>();
        private void BuCalculateMultiplier_Click(object sender, EventArgs e)
        {
			DateTime now = DateTime.Now;
			if (prevClick == null) {
				prevClick = now;
				return;
			}
			timespans.Add(now - prevClick);

			if (timespans.Count > 4)
                timespans.RemoveAt(0);
			else 
				return;

			double avgMs = (timespans[3] - timespans[0]).TotalMilliseconds / 3;
			double msForBpm = 1000.0 / (LastBpm / 60.0);

            double value = (avgMs / msForBpm) * (double)NudAnimSpeedMultiplier.Value;

            double avgValue = value;
            valuesForAvg.Add(value);
			if (valuesForAvg.Count > 10)
			{
                valuesForAvg.RemoveAt(0);
				avgValue = 0;
                foreach (var v in valuesForAvg)
					avgValue += v;
				avgValue /= valuesForAvg.Count;
            }

            BuCalculateMultiplier.Text = Math.Round(value, 2).ToString() + " | " + Math.Round(avgValue, 2).ToString();
        }
    }
}
