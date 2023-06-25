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

namespace AtPulso
{
	public partial class Form1 : Form
	{
		private string version = "1.1";

		public ObservableCollection<WatcherDevice> devices = new ObservableCollection<WatcherDevice>();
		private HeartRateMonitor _heartRateMonitor = new HeartRateMonitor();

		private int lastBpm = 0;

		HttpListener serverListener = new HttpListener();
		bool serverStarted = false;
		CancellationTokenSource tokenSource;
		CancellationToken serverStopToken;

		bool disconnectedByButton = false;

		PulseLog pulseLog = new PulseLog();

		public Form1()
		{
			InitializeComponent();
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
				case 0: width = (int)nudChartWidth.Value + 100 + 150; break; // All
				case 1: width = (int)nudChartWidth.Value + 100; break; // Chart + HR
				case 2: width = 150 + 100; break; // HR + Anim
				case 3: width = 100; break; // HR
			}
			tbObsWidth.Text = width.ToString();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			this.Text = String.Format("AtPulso by GoodVrGames v{0}", version);
			cbAutoConnectAndHide.Checked = Properties.Settings.Default.AutoConnectAndHideToTray;
			cbRetryConnect.Checked = Properties.Settings.Default.RetryConnectWhenFailed;
			cbServerAutostart.Checked = Properties.Settings.Default.AutoStartServerWhenConnected;

			tbDeviceId.Text = Properties.Settings.Default.BleDeviceId;

			nudServerPort.Value = Properties.Settings.Default.ServerPort;

			cbOutputMode.SelectedIndex = Properties.Settings.Default.OutputMode;
			cbOutputOrientation.SelectedIndex = Properties.Settings.Default.OutputOrientation;

			tbHeartRateColor.Text = Properties.Settings.Default.HeartRateColor;

			nudChartDotsCount.Value = Properties.Settings.Default.ChartDotsCount;
			nudChartWidth.Value = Properties.Settings.Default.ChartWidth;
			tbLineColor.Text = Properties.Settings.Default.LineColor;
			tbMinMaxColor.Text = Properties.Settings.Default.MinMaxColor;


			tbAnimationPath.Text = Properties.Settings.Default.AnimationPath;
			nudAnimSpeedMultiplier.Value = Properties.Settings.Default.AnimationSpeedMultiplier;

			// we should always monitor the connection status
			//_heartRateMonitor.ConnectionStatusChanged -= HrDeviceOnDeviceConnectionStatusChanged;
			_heartRateMonitor.ConnectionStatusChanged += HrDeviceOnDeviceConnectionStatusChanged;

			//// we can create value parser and listen for parsed values of given characteristic
			//HrParser.ConnectWithCharacteristic(HrDevice.HeartRate.HeartRateMeasurement);
			//_heartRateMonitor.RateChanged -= HrParserOnValueChanged;
			_heartRateMonitor.RateChanged += HrParserOnValueChanged;

			if (Properties.Settings.Default.AutoConnectAndHideToTray)
			{
				if (!string.IsNullOrEmpty(Properties.Settings.Default.BleDeviceId))
				{
					ConnectToBt();
					tiHideOnStart.Start();
				}
			}
		}

		private void cbAutoConnectAndHide_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoConnectAndHideToTray = cbAutoConnectAndHide.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbRetryConnect_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.RetryConnectWhenFailed = cbRetryConnect.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbServerAutostart_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoStartServerWhenConnected = cbServerAutostart.Checked;
			Properties.Settings.Default.Save();
		}

		private void nudServerPort_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ServerPort = (int)nudServerPort.Value;
			Properties.Settings.Default.Save();
		}

		private void cbOutputMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.OutputMode = cbOutputMode.SelectedIndex;
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
			Properties.Settings.Default.OutputOrientation = cbOutputOrientation.SelectedIndex;
			Properties.Settings.Default.Save();
		}

		private void nudChartDotsCount_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartDotsCount = (int)nudChartDotsCount.Value;
			Properties.Settings.Default.Save();
		}

		private void nudChartWidth_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ChartWidth = (int)nudChartWidth.Value;
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

		private void buDeviceConnect_Click(object sender, EventArgs e)
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

		private async void buDeviceGetInfo_Click(object sender, EventArgs e)
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

		private async void buDeviceDisconnect_Click(object sender, EventArgs e)
		{
			StopServer();
			tbDeviceId.Text = "";
			disconnectedByButton = true;
			if (_heartRateMonitor.IsConnected)
				await _heartRateMonitor.DisconnectAsync();
			Properties.Settings.Default.BleDeviceId = "";
			Properties.Settings.Default.Save();
		}

		private void buStartServer_Click(object sender, EventArgs e)
		{
			StartServer();
		}

		private void buStopServer_Click(object sender, EventArgs e)
		{
			StopServer();
		}

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

		private void nudAnimSpeedMultiplier_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AnimationSpeedMultiplier = nudAnimSpeedMultiplier.Value;
			Properties.Settings.Default.Save();
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
					if (cbSaveHeartrateLog.Checked)
						pulseLog.Add(e.BeatsPerMinute);
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
						buDeviceConnect.Enabled = false;
						buDeviceGetInfo.Enabled = true;
						buDeviceDisconnect.Enabled = true;


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
			else
			{
				this.Invoke((MethodInvoker)delegate {
					tbDeviceStatus.Text = "Disconnected";
					tbDeviceBattery.Text = "--";
					this.Text = "AtPulso by GoodVrGames";
					Log("Disconnected");

					cbTestMode.Checked = false;
					cbTestMode.Enabled = false;
					buDeviceConnect.Enabled = true;
					buDeviceGetInfo.Enabled = false;
					buDeviceDisconnect.Enabled = false;
				});
				if (Properties.Settings.Default.RetryConnectWhenFailed)
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
					tbDeviceStatus.Text = "Error";
					if (Properties.Settings.Default.RetryConnectWhenFailed)
					{
						if (tryNow > 3)
						{
							Properties.Settings.Default.BleDeviceId = "";
							Properties.Settings.Default.AutoConnectAndHideToTray = false;
							Properties.Settings.Default.Save();
							cbAutoConnectAndHide.Checked = false;
							tbDeviceId.Text = "";
							Log("Stop trying to Reconnect after 5 times");
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
					}
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
					buStartServer.Enabled = false;
					buStopServer.Enabled = true;
				});
				while (!serverStopToken.IsCancellationRequested)
					ListeningServer();
				serverStarted = false;
				serverListener.Stop();
				Log("Stop at: " + prefix);
				this.Invoke((MethodInvoker)delegate
				{
					buStartServer.Enabled = true;
					buStopServer.Enabled = false;
				});
			}, serverStopToken);
		}

		private void StopServer()
		{
			tokenSource.Cancel();
		}

		private void ListeningServer()
		{
			try
			{
				HttpListenerContext context = serverListener.GetContextAsync().AsCancellable(serverStopToken).Result;
				HttpListenerRequest request = context.Request;
				if (request.Url.ToString().Contains("getpulse"))
				{
					// get pulse
					HttpListenerResponse response = context.Response;
					string responseString = lastBpm.ToString();
					byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					System.IO.Stream output = response.OutputStream;
					output.Write(buffer, 0, buffer.Length);
					output.Close();
				}
				else if (request.Url.ToString().Contains("chartjs"))
				{
					// other
					HttpListenerResponse response = context.Response;
					string responseString = Properties.Resources.Chartjs;
					byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					System.IO.Stream output = response.OutputStream;
					output.Write(buffer, 0, buffer.Length);
					output.Close();
				}
				else if (request.Url.ToString().Contains("video"))
				{
					HttpListenerResponse response = context.Response;
					byte[] buffer = System.IO.File.ReadAllBytes(Properties.Settings.Default.AnimationPath);
					response.ContentLength64 = buffer.Length;
					System.IO.Stream output = response.OutputStream;
					output.Write(buffer, 0, buffer.Length);
					output.Close();
				}
				else
				{
					// other
					HttpListenerResponse response = context.Response;
					string responseString = Properties.Resources.MainPage;

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
								responseString = responseString.Replace("{video_left}", (Properties.Settings.Default.ChartWidth + 100).ToString());
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
								responseString = responseString.Replace("{video_left}", "100");
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
								responseString = responseString.Replace("{container_left}", "100");
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
					responseString = responseString.Replace("{dots_width}", Properties.Settings.Default.ChartDotsCount.ToString());
					responseString = responseString.Replace("{color_line}", Properties.Settings.Default.LineColor);
					responseString = responseString.Replace("{color_big_number}", Properties.Settings.Default.HeartRateColor);
					responseString = responseString.Replace("{color_small_numbers}", Properties.Settings.Default.MinMaxColor);
					//responseString = responseString.Replace("{display_mode_big_number}", showBigNumber ? "inline-block" : "none");
					responseString = responseString.Replace("{chart_width}", Properties.Settings.Default.ChartWidth.ToString());
					responseString = responseString.Replace("{anim_speed_multiplier}", Properties.Settings.Default.AnimationSpeedMultiplier.ToString().Replace(",", "."));



					byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
					response.ContentLength64 = buffer.Length;
					System.IO.Stream output = response.OutputStream;
					output.Write(buffer, 0, buffer.Length);
					output.Close();
				}
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
			if (cbSaveHeartrateLog.Checked && pulseLog.haveUnsavedData)
			{
				pulseLog.Save();
				if (pulseLog.haveUnsavedData)
					e.Cancel = true;
			}
			if (e.Cancel)
			{
				tiClose.Start();
			}
		}
	}
}
