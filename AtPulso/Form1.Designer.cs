
namespace AtPulso
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbDeviceName = new System.Windows.Forms.TextBox();
			this.tbDeviceBattery = new System.Windows.Forms.TextBox();
			this.tbDeviceStatus = new System.Windows.Forms.TextBox();
			this.tbDeviceId = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.buDeviceGetInfo = new System.Windows.Forms.Button();
			this.buDeviceDisconnect = new System.Windows.Forms.Button();
			this.buDeviceConnect = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tbObsWidth = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.gbChartSettings = new System.Windows.Forms.GroupBox();
			this.nudChartDotsCount = new System.Windows.Forms.NumericUpDown();
			this.buMinMaxColor = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.buLineColor = new System.Windows.Forms.Button();
			this.nudChartWidth = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbLineColor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbMinMaxColor = new System.Windows.Forms.TextBox();
			this.gbAnimationSettings = new System.Windows.Forms.GroupBox();
			this.buAnimationClear = new System.Windows.Forms.Button();
			this.buAnimationSelect = new System.Windows.Forms.Button();
			this.tbAnimationPath = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbOutputOrientation = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbOutputMode = new System.Windows.Forms.ComboBox();
			this.gbHeartRateSettings = new System.Windows.Forms.GroupBox();
			this.buHeartRateColor = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.tbHeartRateColor = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buStopServer = new System.Windows.Forms.Button();
			this.buStartServer = new System.Windows.Forms.Button();
			this.tbServerAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nudServerPort = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbServerAutostart = new System.Windows.Forms.CheckBox();
			this.cbRetryConnect = new System.Windows.Forms.CheckBox();
			this.cbAutoConnectAndHide = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.lbLog = new System.Windows.Forms.ListBox();
			this.cdSelectColor = new System.Windows.Forms.ColorDialog();
			this.ofdSelectAnimation = new System.Windows.Forms.OpenFileDialog();
			this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.tiClose = new System.Windows.Forms.Timer(this.components);
			this.tiHideOnStart = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.gbChartSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudChartDotsCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudChartWidth)).BeginInit();
			this.gbAnimationSettings.SuspendLayout();
			this.gbHeartRateSettings.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbDeviceName);
			this.groupBox1.Controls.Add(this.tbDeviceBattery);
			this.groupBox1.Controls.Add(this.tbDeviceStatus);
			this.groupBox1.Controls.Add(this.tbDeviceId);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.buDeviceGetInfo);
			this.groupBox1.Controls.Add(this.buDeviceDisconnect);
			this.groupBox1.Controls.Add(this.buDeviceConnect);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(215, 180);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Device Settings";
			// 
			// tbDeviceName
			// 
			this.tbDeviceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDeviceName.Location = new System.Drawing.Point(70, 45);
			this.tbDeviceName.Name = "tbDeviceName";
			this.tbDeviceName.ReadOnly = true;
			this.tbDeviceName.Size = new System.Drawing.Size(139, 20);
			this.tbDeviceName.TabIndex = 11;
			// 
			// tbDeviceBattery
			// 
			this.tbDeviceBattery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDeviceBattery.Location = new System.Drawing.Point(70, 71);
			this.tbDeviceBattery.Name = "tbDeviceBattery";
			this.tbDeviceBattery.ReadOnly = true;
			this.tbDeviceBattery.Size = new System.Drawing.Size(139, 20);
			this.tbDeviceBattery.TabIndex = 10;
			// 
			// tbDeviceStatus
			// 
			this.tbDeviceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDeviceStatus.Location = new System.Drawing.Point(70, 97);
			this.tbDeviceStatus.Name = "tbDeviceStatus";
			this.tbDeviceStatus.ReadOnly = true;
			this.tbDeviceStatus.Size = new System.Drawing.Size(139, 20);
			this.tbDeviceStatus.TabIndex = 9;
			// 
			// tbDeviceId
			// 
			this.tbDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDeviceId.Location = new System.Drawing.Point(70, 19);
			this.tbDeviceId.Name = "tbDeviceId";
			this.tbDeviceId.ReadOnly = true;
			this.tbDeviceId.Size = new System.Drawing.Size(139, 20);
			this.tbDeviceId.TabIndex = 8;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 22);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(58, 13);
			this.label16.TabIndex = 7;
			this.label16.Text = "Device ID:";
			// 
			// buDeviceGetInfo
			// 
			this.buDeviceGetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buDeviceGetInfo.Enabled = false;
			this.buDeviceGetInfo.Location = new System.Drawing.Point(9, 150);
			this.buDeviceGetInfo.Name = "buDeviceGetInfo";
			this.buDeviceGetInfo.Size = new System.Drawing.Size(103, 23);
			this.buDeviceGetInfo.TabIndex = 6;
			this.buDeviceGetInfo.Text = "Get Device Info";
			this.buDeviceGetInfo.UseVisualStyleBackColor = true;
			this.buDeviceGetInfo.Click += new System.EventHandler(this.buDeviceGetInfo_Click);
			// 
			// buDeviceDisconnect
			// 
			this.buDeviceDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buDeviceDisconnect.Enabled = false;
			this.buDeviceDisconnect.Location = new System.Drawing.Point(118, 150);
			this.buDeviceDisconnect.Name = "buDeviceDisconnect";
			this.buDeviceDisconnect.Size = new System.Drawing.Size(91, 23);
			this.buDeviceDisconnect.TabIndex = 4;
			this.buDeviceDisconnect.Text = "Disconnect";
			this.buDeviceDisconnect.UseVisualStyleBackColor = true;
			this.buDeviceDisconnect.Click += new System.EventHandler(this.buDeviceDisconnect_Click);
			// 
			// buDeviceConnect
			// 
			this.buDeviceConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buDeviceConnect.Location = new System.Drawing.Point(9, 125);
			this.buDeviceConnect.Name = "buDeviceConnect";
			this.buDeviceConnect.Size = new System.Drawing.Size(103, 23);
			this.buDeviceConnect.TabIndex = 3;
			this.buDeviceConnect.Text = "Connect";
			this.buDeviceConnect.UseVisualStyleBackColor = true;
			this.buDeviceConnect.Click += new System.EventHandler(this.buDeviceConnect_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Battery:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Status:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.groupBox6);
			this.groupBox2.Controls.Add(this.gbChartSettings);
			this.groupBox2.Controls.Add(this.gbAnimationSettings);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.cbOutputOrientation);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.cbOutputMode);
			this.groupBox2.Controls.Add(this.gbHeartRateSettings);
			this.groupBox2.Location = new System.Drawing.Point(233, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(361, 615);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output Settings";
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.label15);
			this.groupBox6.Controls.Add(this.tbObsWidth);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Location = new System.Drawing.Point(9, 364);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(346, 63);
			this.groupBox6.TabIndex = 12;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Hint";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 42);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(73, 13);
			this.label15.TabIndex = 8;
			this.label15.Text = "Height: 150px";
			// 
			// tbObsWidth
			// 
			this.tbObsWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbObsWidth.Location = new System.Drawing.Point(98, 19);
			this.tbObsWidth.Name = "tbObsWidth";
			this.tbObsWidth.ReadOnly = true;
			this.tbObsWidth.Size = new System.Drawing.Size(242, 20);
			this.tbObsWidth.TabIndex = 7;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 22);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(78, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Width for OBS:";
			// 
			// gbChartSettings
			// 
			this.gbChartSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbChartSettings.Controls.Add(this.nudChartDotsCount);
			this.gbChartSettings.Controls.Add(this.buMinMaxColor);
			this.gbChartSettings.Controls.Add(this.label6);
			this.gbChartSettings.Controls.Add(this.buLineColor);
			this.gbChartSettings.Controls.Add(this.nudChartWidth);
			this.gbChartSettings.Controls.Add(this.label12);
			this.gbChartSettings.Controls.Add(this.label8);
			this.gbChartSettings.Controls.Add(this.tbLineColor);
			this.gbChartSettings.Controls.Add(this.label7);
			this.gbChartSettings.Controls.Add(this.tbMinMaxColor);
			this.gbChartSettings.Location = new System.Drawing.Point(9, 71);
			this.gbChartSettings.Name = "gbChartSettings";
			this.gbChartSettings.Size = new System.Drawing.Size(346, 127);
			this.gbChartSettings.TabIndex = 11;
			this.gbChartSettings.TabStop = false;
			this.gbChartSettings.Text = "Chart Settings";
			// 
			// nudChartDotsCount
			// 
			this.nudChartDotsCount.Location = new System.Drawing.Point(98, 19);
			this.nudChartDotsCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudChartDotsCount.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudChartDotsCount.Name = "nudChartDotsCount";
			this.nudChartDotsCount.Size = new System.Drawing.Size(71, 20);
			this.nudChartDotsCount.TabIndex = 2;
			this.nudChartDotsCount.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.nudChartDotsCount.ValueChanged += new System.EventHandler(this.nudChartDotsCount_ValueChanged);
			// 
			// buMinMaxColor
			// 
			this.buMinMaxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buMinMaxColor.Location = new System.Drawing.Point(273, 97);
			this.buMinMaxColor.Name = "buMinMaxColor";
			this.buMinMaxColor.Size = new System.Drawing.Size(67, 20);
			this.buMinMaxColor.TabIndex = 10;
			this.buMinMaxColor.Text = "Select";
			this.buMinMaxColor.UseVisualStyleBackColor = true;
			this.buMinMaxColor.Click += new System.EventHandler(this.buMinMaxColor_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Dots Count:";
			// 
			// buLineColor
			// 
			this.buLineColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buLineColor.Location = new System.Drawing.Point(273, 71);
			this.buLineColor.Name = "buLineColor";
			this.buLineColor.Size = new System.Drawing.Size(67, 20);
			this.buLineColor.TabIndex = 9;
			this.buLineColor.Text = "Select";
			this.buLineColor.UseVisualStyleBackColor = true;
			this.buLineColor.Click += new System.EventHandler(this.buLineColor_Click);
			// 
			// nudChartWidth
			// 
			this.nudChartWidth.Location = new System.Drawing.Point(98, 45);
			this.nudChartWidth.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
			this.nudChartWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudChartWidth.Name = "nudChartWidth";
			this.nudChartWidth.Size = new System.Drawing.Size(71, 20);
			this.nudChartWidth.TabIndex = 9;
			this.nudChartWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudChartWidth.ValueChanged += new System.EventHandler(this.nudChartWidth_ValueChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 47);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 13);
			this.label12.TabIndex = 8;
			this.label12.Text = "Chart width:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Min-Max Color:";
			// 
			// tbLineColor
			// 
			this.tbLineColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLineColor.Location = new System.Drawing.Point(98, 71);
			this.tbLineColor.Name = "tbLineColor";
			this.tbLineColor.ReadOnly = true;
			this.tbLineColor.Size = new System.Drawing.Size(175, 20);
			this.tbLineColor.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Line Color:";
			// 
			// tbMinMaxColor
			// 
			this.tbMinMaxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbMinMaxColor.Location = new System.Drawing.Point(98, 97);
			this.tbMinMaxColor.Name = "tbMinMaxColor";
			this.tbMinMaxColor.ReadOnly = true;
			this.tbMinMaxColor.Size = new System.Drawing.Size(175, 20);
			this.tbMinMaxColor.TabIndex = 5;
			// 
			// gbAnimationSettings
			// 
			this.gbAnimationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbAnimationSettings.Controls.Add(this.buAnimationClear);
			this.gbAnimationSettings.Controls.Add(this.buAnimationSelect);
			this.gbAnimationSettings.Controls.Add(this.tbAnimationPath);
			this.gbAnimationSettings.Controls.Add(this.label13);
			this.gbAnimationSettings.Location = new System.Drawing.Point(9, 265);
			this.gbAnimationSettings.Name = "gbAnimationSettings";
			this.gbAnimationSettings.Size = new System.Drawing.Size(346, 89);
			this.gbAnimationSettings.TabIndex = 10;
			this.gbAnimationSettings.TabStop = false;
			this.gbAnimationSettings.Text = "Animation Settings";
			// 
			// buAnimationClear
			// 
			this.buAnimationClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buAnimationClear.Location = new System.Drawing.Point(272, 59);
			this.buAnimationClear.Name = "buAnimationClear";
			this.buAnimationClear.Size = new System.Drawing.Size(68, 20);
			this.buAnimationClear.TabIndex = 13;
			this.buAnimationClear.Text = "Clear";
			this.buAnimationClear.UseVisualStyleBackColor = true;
			this.buAnimationClear.Click += new System.EventHandler(this.buAnimationClear_Click);
			// 
			// buAnimationSelect
			// 
			this.buAnimationSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buAnimationSelect.Location = new System.Drawing.Point(9, 59);
			this.buAnimationSelect.Name = "buAnimationSelect";
			this.buAnimationSelect.Size = new System.Drawing.Size(257, 20);
			this.buAnimationSelect.TabIndex = 12;
			this.buAnimationSelect.Text = "Select";
			this.buAnimationSelect.UseVisualStyleBackColor = true;
			this.buAnimationSelect.Click += new System.EventHandler(this.buAnimationSelect_Click);
			// 
			// tbAnimationPath
			// 
			this.tbAnimationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAnimationPath.Location = new System.Drawing.Point(9, 33);
			this.tbAnimationPath.Name = "tbAnimationPath";
			this.tbAnimationPath.ReadOnly = true;
			this.tbAnimationPath.Size = new System.Drawing.Size(331, 20);
			this.tbAnimationPath.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(251, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "For better result need 1 sec webm-video with 1 beat";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 13);
			this.label11.TabIndex = 7;
			this.label11.Text = "Orientation:";
			// 
			// cbOutputOrientation
			// 
			this.cbOutputOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbOutputOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOutputOrientation.FormattingEnabled = true;
			this.cbOutputOrientation.Items.AddRange(new object[] {
            "Right-sided",
            "Left-sided"});
			this.cbOutputOrientation.Location = new System.Drawing.Point(84, 44);
			this.cbOutputOrientation.Name = "cbOutputOrientation";
			this.cbOutputOrientation.Size = new System.Drawing.Size(271, 21);
			this.cbOutputOrientation.TabIndex = 6;
			this.cbOutputOrientation.SelectedIndexChanged += new System.EventHandler(this.cbOutputOrientation_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Output Mode:";
			// 
			// cbOutputMode
			// 
			this.cbOutputMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbOutputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOutputMode.FormattingEnabled = true;
			this.cbOutputMode.Items.AddRange(new object[] {
            "All (Chart + HeartRate + Animation)",
            "Chart + HeartRate",
            "HeartRate + Animation",
            "HeartRate only"});
			this.cbOutputMode.Location = new System.Drawing.Point(84, 17);
			this.cbOutputMode.Name = "cbOutputMode";
			this.cbOutputMode.Size = new System.Drawing.Size(271, 21);
			this.cbOutputMode.TabIndex = 4;
			this.cbOutputMode.SelectedIndexChanged += new System.EventHandler(this.cbOutputMode_SelectedIndexChanged);
			// 
			// gbHeartRateSettings
			// 
			this.gbHeartRateSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbHeartRateSettings.Controls.Add(this.buHeartRateColor);
			this.gbHeartRateSettings.Controls.Add(this.label9);
			this.gbHeartRateSettings.Controls.Add(this.tbHeartRateColor);
			this.gbHeartRateSettings.Location = new System.Drawing.Point(9, 204);
			this.gbHeartRateSettings.Name = "gbHeartRateSettings";
			this.gbHeartRateSettings.Size = new System.Drawing.Size(346, 55);
			this.gbHeartRateSettings.TabIndex = 3;
			this.gbHeartRateSettings.TabStop = false;
			this.gbHeartRateSettings.Text = "HeartRate Settings";
			// 
			// buHeartRateColor
			// 
			this.buHeartRateColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buHeartRateColor.Location = new System.Drawing.Point(273, 19);
			this.buHeartRateColor.Name = "buHeartRateColor";
			this.buHeartRateColor.Size = new System.Drawing.Size(67, 20);
			this.buHeartRateColor.TabIndex = 11;
			this.buHeartRateColor.Text = "Select";
			this.buHeartRateColor.UseVisualStyleBackColor = true;
			this.buHeartRateColor.Click += new System.EventHandler(this.buHeartRateColor_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "HeartRate Color:";
			// 
			// tbHeartRateColor
			// 
			this.tbHeartRateColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbHeartRateColor.Location = new System.Drawing.Point(98, 19);
			this.tbHeartRateColor.Name = "tbHeartRateColor";
			this.tbHeartRateColor.ReadOnly = true;
			this.tbHeartRateColor.Size = new System.Drawing.Size(175, 20);
			this.tbHeartRateColor.TabIndex = 6;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buStopServer);
			this.groupBox3.Controls.Add(this.buStartServer);
			this.groupBox3.Controls.Add(this.tbServerAddress);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.nudServerPort);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(12, 294);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(215, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Server Settings";
			// 
			// buStopServer
			// 
			this.buStopServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buStopServer.Enabled = false;
			this.buStopServer.Location = new System.Drawing.Point(118, 70);
			this.buStopServer.Name = "buStopServer";
			this.buStopServer.Size = new System.Drawing.Size(91, 23);
			this.buStopServer.TabIndex = 5;
			this.buStopServer.Text = "Stop";
			this.buStopServer.UseVisualStyleBackColor = true;
			this.buStopServer.Click += new System.EventHandler(this.buStopServer_Click);
			// 
			// buStartServer
			// 
			this.buStartServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buStartServer.Location = new System.Drawing.Point(9, 70);
			this.buStartServer.Name = "buStartServer";
			this.buStartServer.Size = new System.Drawing.Size(103, 23);
			this.buStartServer.TabIndex = 4;
			this.buStartServer.Text = "Start";
			this.buStartServer.UseVisualStyleBackColor = true;
			this.buStartServer.Click += new System.EventHandler(this.buStartServer_Click);
			// 
			// tbServerAddress
			// 
			this.tbServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbServerAddress.Location = new System.Drawing.Point(60, 44);
			this.tbServerAddress.Name = "tbServerAddress";
			this.tbServerAddress.ReadOnly = true;
			this.tbServerAddress.Size = new System.Drawing.Size(149, 20);
			this.tbServerAddress.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Address:";
			// 
			// nudServerPort
			// 
			this.nudServerPort.Location = new System.Drawing.Point(60, 18);
			this.nudServerPort.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
			this.nudServerPort.Name = "nudServerPort";
			this.nudServerPort.Size = new System.Drawing.Size(63, 20);
			this.nudServerPort.TabIndex = 1;
			this.nudServerPort.Value = new decimal(new int[] {
            10110,
            0,
            0,
            0});
			this.nudServerPort.ValueChanged += new System.EventHandler(this.nudServerPort_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Port:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbServerAutostart);
			this.groupBox4.Controls.Add(this.cbRetryConnect);
			this.groupBox4.Controls.Add(this.cbAutoConnectAndHide);
			this.groupBox4.Location = new System.Drawing.Point(12, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(215, 89);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "App Settings";
			// 
			// cbServerAutostart
			// 
			this.cbServerAutostart.AutoSize = true;
			this.cbServerAutostart.Checked = true;
			this.cbServerAutostart.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbServerAutostart.Location = new System.Drawing.Point(6, 65);
			this.cbServerAutostart.Name = "cbServerAutostart";
			this.cbServerAutostart.Size = new System.Drawing.Size(183, 17);
			this.cbServerAutostart.TabIndex = 2;
			this.cbServerAutostart.Text = "Autostart server when connected";
			this.cbServerAutostart.UseVisualStyleBackColor = true;
			this.cbServerAutostart.CheckedChanged += new System.EventHandler(this.cbServerAutostart_CheckedChanged);
			// 
			// cbRetryConnect
			// 
			this.cbRetryConnect.AutoSize = true;
			this.cbRetryConnect.Location = new System.Drawing.Point(6, 42);
			this.cbRetryConnect.Name = "cbRetryConnect";
			this.cbRetryConnect.Size = new System.Drawing.Size(150, 17);
			this.cbRetryConnect.TabIndex = 1;
			this.cbRetryConnect.Text = "Retry connect when failed";
			this.cbRetryConnect.UseVisualStyleBackColor = true;
			this.cbRetryConnect.CheckedChanged += new System.EventHandler(this.cbRetryConnect_CheckedChanged);
			// 
			// cbAutoConnectAndHide
			// 
			this.cbAutoConnectAndHide.AutoSize = true;
			this.cbAutoConnectAndHide.Location = new System.Drawing.Point(6, 19);
			this.cbAutoConnectAndHide.Name = "cbAutoConnectAndHide";
			this.cbAutoConnectAndHide.Size = new System.Drawing.Size(205, 17);
			this.cbAutoConnectAndHide.TabIndex = 0;
			this.cbAutoConnectAndHide.Text = "AutoConnect and Hide to Tray at start";
			this.cbAutoConnectAndHide.UseVisualStyleBackColor = true;
			this.cbAutoConnectAndHide.CheckedChanged += new System.EventHandler(this.cbAutoConnectAndHide_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox5.Controls.Add(this.tbLog);
			this.groupBox5.Controls.Add(this.lbLog);
			this.groupBox5.Location = new System.Drawing.Point(12, 400);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(215, 227);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Log";
			// 
			// tbLog
			// 
			this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLog.Location = new System.Drawing.Point(6, 19);
			this.tbLog.Name = "tbLog";
			this.tbLog.ReadOnly = true;
			this.tbLog.Size = new System.Drawing.Size(203, 20);
			this.tbLog.TabIndex = 4;
			// 
			// lbLog
			// 
			this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbLog.FormattingEnabled = true;
			this.lbLog.Location = new System.Drawing.Point(6, 45);
			this.lbLog.Name = "lbLog";
			this.lbLog.Size = new System.Drawing.Size(203, 147);
			this.lbLog.TabIndex = 0;
			this.lbLog.Click += new System.EventHandler(this.lbLog_Click);
			// 
			// ofdSelectAnimation
			// 
			this.ofdSelectAnimation.Filter = "*.webm | *.webm";
			this.ofdSelectAnimation.Title = "AtPulso - Select Webm Animation";
			// 
			// niTray
			// 
			this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
			this.niTray.Text = "AtPulso";
			this.niTray.Click += new System.EventHandler(this.niTray_Click);
			// 
			// tiClose
			// 
			this.tiClose.Interval = 1000;
			this.tiClose.Tick += new System.EventHandler(this.tiClose_Tick);
			// 
			// tiHideOnStart
			// 
			this.tiHideOnStart.Interval = 1000;
			this.tiHideOnStart.Tick += new System.EventHandler(this.tiHideOnStart_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 641);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "AtPulso by GoodVrGames";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.gbChartSettings.ResumeLayout(false);
			this.gbChartSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudChartDotsCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudChartWidth)).EndInit();
			this.gbAnimationSettings.ResumeLayout(false);
			this.gbAnimationSettings.PerformLayout();
			this.gbHeartRateSettings.ResumeLayout(false);
			this.gbHeartRateSettings.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buDeviceDisconnect;
		private System.Windows.Forms.Button buDeviceConnect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buStopServer;
		private System.Windows.Forms.Button buStartServer;
		private System.Windows.Forms.TextBox tbServerAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudServerPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox cbRetryConnect;
		private System.Windows.Forms.CheckBox cbAutoConnectAndHide;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox tbLog;
		private System.Windows.Forms.ListBox lbLog;
		private System.Windows.Forms.GroupBox gbHeartRateSettings;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbHeartRateColor;
		private System.Windows.Forms.TextBox tbMinMaxColor;
		private System.Windows.Forms.TextBox tbLineColor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudChartDotsCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColorDialog cdSelectColor;
		private System.Windows.Forms.GroupBox gbChartSettings;
		private System.Windows.Forms.NumericUpDown nudChartWidth;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox gbAnimationSettings;
		private System.Windows.Forms.Button buAnimationClear;
		private System.Windows.Forms.Button buAnimationSelect;
		private System.Windows.Forms.TextBox tbAnimationPath;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbOutputOrientation;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbOutputMode;
		private System.Windows.Forms.Button buHeartRateColor;
		private System.Windows.Forms.Button buMinMaxColor;
		private System.Windows.Forms.Button buLineColor;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox tbObsWidth;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox cbServerAutostart;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.OpenFileDialog ofdSelectAnimation;
		private System.Windows.Forms.TextBox tbDeviceName;
		private System.Windows.Forms.TextBox tbDeviceBattery;
		private System.Windows.Forms.TextBox tbDeviceStatus;
		private System.Windows.Forms.TextBox tbDeviceId;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button buDeviceGetInfo;
		private System.Windows.Forms.NotifyIcon niTray;
		private System.Windows.Forms.Timer tiClose;
		private System.Windows.Forms.Timer tiHideOnStart;
	}
}

