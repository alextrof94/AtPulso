
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
            this.TbDeviceName = new System.Windows.Forms.TextBox();
            this.TbDeviceBattery = new System.Windows.Forms.TextBox();
            this.TbDeviceStatus = new System.Windows.Forms.TextBox();
            this.TbDeviceId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuOpenCssFontPage = new System.Windows.Forms.Button();
            this.TbFontFamily = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CbOutputOrientation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbOutputMode = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TbObsWidth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbChartSettings = new System.Windows.Forms.GroupBox();
            this.PbMinMaxColor = new System.Windows.Forms.PictureBox();
            this.PbLineColor = new System.Windows.Forms.PictureBox();
            this.CbChartLineSmooth = new System.Windows.Forms.CheckBox();
            this.NudChartLineThickness = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.NudChartDotsCount = new System.Windows.Forms.NumericUpDown();
            this.BuMinMaxColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BuLineColor = new System.Windows.Forms.Button();
            this.NudChartWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbLineColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbMinMaxColor = new System.Windows.Forms.TextBox();
            this.gbAnimationSettings = new System.Windows.Forms.GroupBox();
            this.BuCalculateMultiplier = new System.Windows.Forms.Button();
            this.BuOpenFilterPage = new System.Windows.Forms.Button();
            this.TbAnimFilter = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.NudAnimSpeedMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.BuAnimationClear = new System.Windows.Forms.Button();
            this.BuAnimationSelect = new System.Windows.Forms.Button();
            this.TbAnimationPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbHeartRateSettings = new System.Windows.Forms.GroupBox();
            this.PbHeartRateThresholdColor = new System.Windows.Forms.PictureBox();
            this.PbHeartRateColor = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CbHeartRateOutlineStyle = new System.Windows.Forms.ComboBox();
            this.NudHeartRateFontSize = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.BuHeartRateThresholdColor = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.TbHeartRateThresholdColor = new System.Windows.Forms.TextBox();
            this.NudHeartRateThreshold = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.CbHeartRateThresholdChange = new System.Windows.Forms.CheckBox();
            this.BuHeartRateColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TbHeartRateColor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbServerAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NudServerPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TbVolume = new System.Windows.Forms.TrackBar();
            this.CbAutoShowPreview = new System.Windows.Forms.CheckBox();
            this.CbSoundAlert = new System.Windows.Forms.CheckBox();
            this.CbHideAtStart = new System.Windows.Forms.CheckBox();
            this.CbServerAutostart = new System.Windows.Forms.CheckBox();
            this.CbRetryConnect = new System.Windows.Forms.CheckBox();
            this.CbAutoConnectAtStart = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.LbLog = new System.Windows.Forms.ListBox();
            this.cdSelectColor = new System.Windows.Forms.ColorDialog();
            this.ofdSelectAnimation = new System.Windows.Forms.OpenFileDialog();
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tiClose = new System.Windows.Forms.Timer(this.components);
            this.tiHideOnStart = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDeviceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPreviewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTwitchChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSuggestionsOrIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabMain = new System.Windows.Forms.TabPage();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.TabOutput = new System.Windows.Forms.TabPage();
            this.TabHeartRate = new System.Windows.Forms.TabPage();
            this.TabChart = new System.Windows.Forms.TabPage();
            this.TabAnimation = new System.Windows.Forms.TabPage();
            this.cbTestMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbChartSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinMaxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChartLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChartDotsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChartWidth)).BeginInit();
            this.gbAnimationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnimSpeedMultiplier)).BeginInit();
            this.gbHeartRateSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbHeartRateThresholdColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHeartRateColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeartRateFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeartRateThreshold)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudServerPort)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbVolume)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabSettings.SuspendLayout();
            this.TabOutput.SuspendLayout();
            this.TabHeartRate.SuspendLayout();
            this.TabChart.SuspendLayout();
            this.TabAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TbDeviceName);
            this.groupBox1.Controls.Add(this.TbDeviceBattery);
            this.groupBox1.Controls.Add(this.TbDeviceStatus);
            this.groupBox1.Controls.Add(this.TbDeviceId);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info";
            // 
            // TbDeviceName
            // 
            this.TbDeviceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDeviceName.Location = new System.Drawing.Point(70, 45);
            this.TbDeviceName.Name = "TbDeviceName";
            this.TbDeviceName.ReadOnly = true;
            this.TbDeviceName.Size = new System.Drawing.Size(362, 20);
            this.TbDeviceName.TabIndex = 11;
            // 
            // TbDeviceBattery
            // 
            this.TbDeviceBattery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDeviceBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDeviceBattery.Location = new System.Drawing.Point(70, 71);
            this.TbDeviceBattery.Name = "TbDeviceBattery";
            this.TbDeviceBattery.ReadOnly = true;
            this.TbDeviceBattery.Size = new System.Drawing.Size(362, 20);
            this.TbDeviceBattery.TabIndex = 10;
            // 
            // TbDeviceStatus
            // 
            this.TbDeviceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDeviceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDeviceStatus.Location = new System.Drawing.Point(70, 97);
            this.TbDeviceStatus.Name = "TbDeviceStatus";
            this.TbDeviceStatus.ReadOnly = true;
            this.TbDeviceStatus.Size = new System.Drawing.Size(362, 20);
            this.TbDeviceStatus.TabIndex = 9;
            // 
            // TbDeviceId
            // 
            this.TbDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDeviceId.Location = new System.Drawing.Point(70, 19);
            this.TbDeviceId.Name = "TbDeviceId";
            this.TbDeviceId.ReadOnly = true;
            this.TbDeviceId.Size = new System.Drawing.Size(362, 20);
            this.TbDeviceId.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Device ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Battery:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.groupBox2.Controls.Add(this.BuOpenCssFontPage);
            this.groupBox2.Controls.Add(this.TbFontFamily);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CbOutputOrientation);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CbOutputMode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Settings";
            // 
            // BuOpenCssFontPage
            // 
            this.BuOpenCssFontPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuOpenCssFontPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuOpenCssFontPage.Location = new System.Drawing.Point(411, 74);
            this.BuOpenCssFontPage.Name = "BuOpenCssFontPage";
            this.BuOpenCssFontPage.Size = new System.Drawing.Size(21, 20);
            this.BuOpenCssFontPage.TabIndex = 20;
            this.BuOpenCssFontPage.Text = "?";
            this.BuOpenCssFontPage.UseVisualStyleBackColor = true;
            this.BuOpenCssFontPage.Click += new System.EventHandler(this.BuOpenCssFontPage_Click);
            // 
            // TbFontFamily
            // 
            this.TbFontFamily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbFontFamily.Location = new System.Drawing.Point(142, 74);
            this.TbFontFamily.Name = "TbFontFamily";
            this.TbFontFamily.Size = new System.Drawing.Size(263, 20);
            this.TbFontFamily.TabIndex = 19;
            this.TbFontFamily.Text = "cursive";
            this.TbFontFamily.TextChanged += new System.EventHandler(this.TbFontFamily_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(6, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Override font-family (CSS):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Orientation:";
            // 
            // CbOutputOrientation
            // 
            this.CbOutputOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbOutputOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOutputOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbOutputOrientation.FormattingEnabled = true;
            this.CbOutputOrientation.Items.AddRange(new object[] {
            "Right-sided",
            "Left-sided"});
            this.CbOutputOrientation.Location = new System.Drawing.Point(84, 47);
            this.CbOutputOrientation.Name = "CbOutputOrientation";
            this.CbOutputOrientation.Size = new System.Drawing.Size(348, 21);
            this.CbOutputOrientation.TabIndex = 6;
            this.CbOutputOrientation.SelectedIndexChanged += new System.EventHandler(this.cbOutputOrientation_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Output Mode:";
            // 
            // CbOutputMode
            // 
            this.CbOutputMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbOutputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOutputMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbOutputMode.FormattingEnabled = true;
            this.CbOutputMode.Items.AddRange(new object[] {
            "All (Chart + HeartRate + Animation)",
            "Chart + HeartRate",
            "HeartRate + Animation",
            "HeartRate only"});
            this.CbOutputMode.Location = new System.Drawing.Point(84, 20);
            this.CbOutputMode.Name = "CbOutputMode";
            this.CbOutputMode.Size = new System.Drawing.Size(348, 21);
            this.CbOutputMode.TabIndex = 4;
            this.CbOutputMode.SelectedIndexChanged += new System.EventHandler(this.CbOutputMode_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.TbObsWidth);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(12, 304);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 146);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hint";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(6, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(264, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "All settings updating on the fly (refresh browser/widget)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Height for OBS:     150";
            // 
            // TbObsWidth
            // 
            this.TbObsWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbObsWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbObsWidth.Location = new System.Drawing.Point(98, 19);
            this.TbObsWidth.Name = "TbObsWidth";
            this.TbObsWidth.ReadOnly = true;
            this.TbObsWidth.Size = new System.Drawing.Size(172, 20);
            this.TbObsWidth.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Width for OBS:";
            // 
            // gbChartSettings
            // 
            this.gbChartSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChartSettings.Controls.Add(this.PbMinMaxColor);
            this.gbChartSettings.Controls.Add(this.PbLineColor);
            this.gbChartSettings.Controls.Add(this.CbChartLineSmooth);
            this.gbChartSettings.Controls.Add(this.NudChartLineThickness);
            this.gbChartSettings.Controls.Add(this.label20);
            this.gbChartSettings.Controls.Add(this.NudChartDotsCount);
            this.gbChartSettings.Controls.Add(this.BuMinMaxColor);
            this.gbChartSettings.Controls.Add(this.label6);
            this.gbChartSettings.Controls.Add(this.BuLineColor);
            this.gbChartSettings.Controls.Add(this.NudChartWidth);
            this.gbChartSettings.Controls.Add(this.label12);
            this.gbChartSettings.Controls.Add(this.label8);
            this.gbChartSettings.Controls.Add(this.TbLineColor);
            this.gbChartSettings.Controls.Add(this.label7);
            this.gbChartSettings.Controls.Add(this.TbMinMaxColor);
            this.gbChartSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChartSettings.Location = new System.Drawing.Point(6, 6);
            this.gbChartSettings.Name = "gbChartSettings";
            this.gbChartSettings.Size = new System.Drawing.Size(438, 236);
            this.gbChartSettings.TabIndex = 11;
            this.gbChartSettings.TabStop = false;
            this.gbChartSettings.Text = "Chart Settings";
            // 
            // PbMinMaxColor
            // 
            this.PbMinMaxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMinMaxColor.Location = new System.Drawing.Point(339, 148);
            this.PbMinMaxColor.Name = "PbMinMaxColor";
            this.PbMinMaxColor.Size = new System.Drawing.Size(20, 20);
            this.PbMinMaxColor.TabIndex = 25;
            this.PbMinMaxColor.TabStop = false;
            // 
            // PbLineColor
            // 
            this.PbLineColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLineColor.Location = new System.Drawing.Point(339, 122);
            this.PbLineColor.Name = "PbLineColor";
            this.PbLineColor.Size = new System.Drawing.Size(20, 20);
            this.PbLineColor.TabIndex = 24;
            this.PbLineColor.TabStop = false;
            // 
            // CbChartLineSmooth
            // 
            this.CbChartLineSmooth.AutoSize = true;
            this.CbChartLineSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbChartLineSmooth.Location = new System.Drawing.Point(9, 97);
            this.CbChartLineSmooth.Name = "CbChartLineSmooth";
            this.CbChartLineSmooth.Size = new System.Drawing.Size(85, 17);
            this.CbChartLineSmooth.TabIndex = 13;
            this.CbChartLineSmooth.Text = "Smooth Line";
            this.CbChartLineSmooth.UseVisualStyleBackColor = true;
            this.CbChartLineSmooth.CheckedChanged += new System.EventHandler(this.CbChartLineSmooth_CheckedChanged);
            // 
            // NudChartLineThickness
            // 
            this.NudChartLineThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudChartLineThickness.Location = new System.Drawing.Point(166, 71);
            this.NudChartLineThickness.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudChartLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudChartLineThickness.Name = "NudChartLineThickness";
            this.NudChartLineThickness.Size = new System.Drawing.Size(71, 20);
            this.NudChartLineThickness.TabIndex = 12;
            this.NudChartLineThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudChartLineThickness.ValueChanged += new System.EventHandler(this.NudChartLineWidth_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(6, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Line Thickness:";
            // 
            // NudChartDotsCount
            // 
            this.NudChartDotsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudChartDotsCount.Location = new System.Drawing.Point(166, 19);
            this.NudChartDotsCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudChartDotsCount.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudChartDotsCount.Name = "NudChartDotsCount";
            this.NudChartDotsCount.Size = new System.Drawing.Size(71, 20);
            this.NudChartDotsCount.TabIndex = 2;
            this.NudChartDotsCount.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NudChartDotsCount.ValueChanged += new System.EventHandler(this.NudChartDotsCount_ValueChanged);
            // 
            // BuMinMaxColor
            // 
            this.BuMinMaxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuMinMaxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuMinMaxColor.Location = new System.Drawing.Point(365, 148);
            this.BuMinMaxColor.Name = "BuMinMaxColor";
            this.BuMinMaxColor.Size = new System.Drawing.Size(67, 20);
            this.BuMinMaxColor.TabIndex = 10;
            this.BuMinMaxColor.Text = "Select";
            this.BuMinMaxColor.UseVisualStyleBackColor = true;
            this.BuMinMaxColor.Click += new System.EventHandler(this.BuMinMaxColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Measuring point count at chart:";
            // 
            // BuLineColor
            // 
            this.BuLineColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuLineColor.Location = new System.Drawing.Point(365, 122);
            this.BuLineColor.Name = "BuLineColor";
            this.BuLineColor.Size = new System.Drawing.Size(67, 20);
            this.BuLineColor.TabIndex = 9;
            this.BuLineColor.Text = "Select";
            this.BuLineColor.UseVisualStyleBackColor = true;
            this.BuLineColor.Click += new System.EventHandler(this.BuLineColor_Click);
            // 
            // NudChartWidth
            // 
            this.NudChartWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudChartWidth.Location = new System.Drawing.Point(166, 45);
            this.NudChartWidth.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.NudChartWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudChartWidth.Name = "NudChartWidth";
            this.NudChartWidth.Size = new System.Drawing.Size(71, 20);
            this.NudChartWidth.TabIndex = 9;
            this.NudChartWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NudChartWidth.ValueChanged += new System.EventHandler(this.NudChartWidth_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Chart Width (px):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Min-Max Color:";
            // 
            // TbLineColor
            // 
            this.TbLineColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLineColor.Location = new System.Drawing.Point(130, 122);
            this.TbLineColor.Name = "TbLineColor";
            this.TbLineColor.ReadOnly = true;
            this.TbLineColor.Size = new System.Drawing.Size(203, 20);
            this.TbLineColor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Line Color:";
            // 
            // TbMinMaxColor
            // 
            this.TbMinMaxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbMinMaxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbMinMaxColor.Location = new System.Drawing.Point(130, 148);
            this.TbMinMaxColor.Name = "TbMinMaxColor";
            this.TbMinMaxColor.ReadOnly = true;
            this.TbMinMaxColor.Size = new System.Drawing.Size(203, 20);
            this.TbMinMaxColor.TabIndex = 5;
            // 
            // gbAnimationSettings
            // 
            this.gbAnimationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAnimationSettings.Controls.Add(this.cbTestMode);
            this.gbAnimationSettings.Controls.Add(this.BuCalculateMultiplier);
            this.gbAnimationSettings.Controls.Add(this.BuOpenFilterPage);
            this.gbAnimationSettings.Controls.Add(this.TbAnimFilter);
            this.gbAnimationSettings.Controls.Add(this.label19);
            this.gbAnimationSettings.Controls.Add(this.NudAnimSpeedMultiplier);
            this.gbAnimationSettings.Controls.Add(this.label17);
            this.gbAnimationSettings.Controls.Add(this.BuAnimationClear);
            this.gbAnimationSettings.Controls.Add(this.BuAnimationSelect);
            this.gbAnimationSettings.Controls.Add(this.TbAnimationPath);
            this.gbAnimationSettings.Controls.Add(this.label13);
            this.gbAnimationSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAnimationSettings.Location = new System.Drawing.Point(6, 6);
            this.gbAnimationSettings.Name = "gbAnimationSettings";
            this.gbAnimationSettings.Size = new System.Drawing.Size(441, 236);
            this.gbAnimationSettings.TabIndex = 10;
            this.gbAnimationSettings.TabStop = false;
            this.gbAnimationSettings.Text = "Animation Settings";
            // 
            // BuCalculateMultiplier
            // 
            this.BuCalculateMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuCalculateMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuCalculateMultiplier.Location = new System.Drawing.Point(9, 170);
            this.BuCalculateMultiplier.Name = "BuCalculateMultiplier";
            this.BuCalculateMultiplier.Size = new System.Drawing.Size(426, 23);
            this.BuCalculateMultiplier.TabIndex = 19;
            this.BuCalculateMultiplier.Text = "Press 5 times to calculate Multiplier (15+ for filtered)";
            this.BuCalculateMultiplier.UseVisualStyleBackColor = true;
            this.BuCalculateMultiplier.Click += new System.EventHandler(this.BuCalculateMultiplier_Click);
            // 
            // BuOpenFilterPage
            // 
            this.BuOpenFilterPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuOpenFilterPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuOpenFilterPage.Location = new System.Drawing.Point(414, 111);
            this.BuOpenFilterPage.Name = "BuOpenFilterPage";
            this.BuOpenFilterPage.Size = new System.Drawing.Size(21, 20);
            this.BuOpenFilterPage.TabIndex = 18;
            this.BuOpenFilterPage.Text = "?";
            this.BuOpenFilterPage.UseVisualStyleBackColor = true;
            this.BuOpenFilterPage.Click += new System.EventHandler(this.BuOpenFilterPage_Click);
            // 
            // TbAnimFilter
            // 
            this.TbAnimFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnimFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbAnimFilter.Location = new System.Drawing.Point(98, 111);
            this.TbAnimFilter.Name = "TbAnimFilter";
            this.TbAnimFilter.Size = new System.Drawing.Size(310, 20);
            this.TbAnimFilter.TabIndex = 17;
            this.TbAnimFilter.TextChanged += new System.EventHandler(this.TbAnimFilter_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(6, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "CSS Filter:";
            // 
            // NudAnimSpeedMultiplier
            // 
            this.NudAnimSpeedMultiplier.DecimalPlaces = 2;
            this.NudAnimSpeedMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudAnimSpeedMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudAnimSpeedMultiplier.Location = new System.Drawing.Point(98, 85);
            this.NudAnimSpeedMultiplier.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudAnimSpeedMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NudAnimSpeedMultiplier.Name = "NudAnimSpeedMultiplier";
            this.NudAnimSpeedMultiplier.Size = new System.Drawing.Size(52, 20);
            this.NudAnimSpeedMultiplier.TabIndex = 15;
            this.NudAnimSpeedMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAnimSpeedMultiplier.ValueChanged += new System.EventHandler(this.NudAnimSpeedMultiplier_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Speed Multiplier:";
            // 
            // BuAnimationClear
            // 
            this.BuAnimationClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuAnimationClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuAnimationClear.Location = new System.Drawing.Point(367, 59);
            this.BuAnimationClear.Name = "BuAnimationClear";
            this.BuAnimationClear.Size = new System.Drawing.Size(68, 20);
            this.BuAnimationClear.TabIndex = 13;
            this.BuAnimationClear.Text = "Clear";
            this.BuAnimationClear.UseVisualStyleBackColor = true;
            this.BuAnimationClear.Click += new System.EventHandler(this.BuAnimationClear_Click);
            // 
            // BuAnimationSelect
            // 
            this.BuAnimationSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuAnimationSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuAnimationSelect.Location = new System.Drawing.Point(9, 59);
            this.BuAnimationSelect.Name = "BuAnimationSelect";
            this.BuAnimationSelect.Size = new System.Drawing.Size(352, 20);
            this.BuAnimationSelect.TabIndex = 12;
            this.BuAnimationSelect.Text = "Select";
            this.BuAnimationSelect.UseVisualStyleBackColor = true;
            this.BuAnimationSelect.Click += new System.EventHandler(this.BuAnimationSelect_Click);
            // 
            // TbAnimationPath
            // 
            this.TbAnimationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnimationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbAnimationPath.Location = new System.Drawing.Point(9, 33);
            this.TbAnimationPath.Name = "TbAnimationPath";
            this.TbAnimationPath.ReadOnly = true;
            this.TbAnimationPath.Size = new System.Drawing.Size(426, 20);
            this.TbAnimationPath.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "For better result need 1 sec webm-video with 1 beat";
            // 
            // gbHeartRateSettings
            // 
            this.gbHeartRateSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeartRateSettings.Controls.Add(this.PbHeartRateThresholdColor);
            this.gbHeartRateSettings.Controls.Add(this.PbHeartRateColor);
            this.gbHeartRateSettings.Controls.Add(this.label25);
            this.gbHeartRateSettings.Controls.Add(this.CbHeartRateOutlineStyle);
            this.gbHeartRateSettings.Controls.Add(this.NudHeartRateFontSize);
            this.gbHeartRateSettings.Controls.Add(this.label24);
            this.gbHeartRateSettings.Controls.Add(this.BuHeartRateThresholdColor);
            this.gbHeartRateSettings.Controls.Add(this.label23);
            this.gbHeartRateSettings.Controls.Add(this.TbHeartRateThresholdColor);
            this.gbHeartRateSettings.Controls.Add(this.NudHeartRateThreshold);
            this.gbHeartRateSettings.Controls.Add(this.label22);
            this.gbHeartRateSettings.Controls.Add(this.CbHeartRateThresholdChange);
            this.gbHeartRateSettings.Controls.Add(this.BuHeartRateColor);
            this.gbHeartRateSettings.Controls.Add(this.label9);
            this.gbHeartRateSettings.Controls.Add(this.TbHeartRateColor);
            this.gbHeartRateSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbHeartRateSettings.Location = new System.Drawing.Point(6, 6);
            this.gbHeartRateSettings.Name = "gbHeartRateSettings";
            this.gbHeartRateSettings.Size = new System.Drawing.Size(438, 236);
            this.gbHeartRateSettings.TabIndex = 3;
            this.gbHeartRateSettings.TabStop = false;
            this.gbHeartRateSettings.Text = "HeartRate Settings";
            // 
            // PbHeartRateThresholdColor
            // 
            this.PbHeartRateThresholdColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbHeartRateThresholdColor.Location = new System.Drawing.Point(339, 147);
            this.PbHeartRateThresholdColor.Name = "PbHeartRateThresholdColor";
            this.PbHeartRateThresholdColor.Size = new System.Drawing.Size(20, 20);
            this.PbHeartRateThresholdColor.TabIndex = 23;
            this.PbHeartRateThresholdColor.TabStop = false;
            // 
            // PbHeartRateColor
            // 
            this.PbHeartRateColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbHeartRateColor.Location = new System.Drawing.Point(339, 19);
            this.PbHeartRateColor.Name = "PbHeartRateColor";
            this.PbHeartRateColor.Size = new System.Drawing.Size(20, 20);
            this.PbHeartRateColor.TabIndex = 22;
            this.PbHeartRateColor.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(6, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Outline Style:";
            // 
            // CbHeartRateOutlineStyle
            // 
            this.CbHeartRateOutlineStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbHeartRateOutlineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbHeartRateOutlineStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbHeartRateOutlineStyle.FormattingEnabled = true;
            this.CbHeartRateOutlineStyle.Items.AddRange(new object[] {
            "None",
            "Glow",
            "Stroke Black",
            "Stroke White"});
            this.CbHeartRateOutlineStyle.Location = new System.Drawing.Point(98, 45);
            this.CbHeartRateOutlineStyle.Name = "CbHeartRateOutlineStyle";
            this.CbHeartRateOutlineStyle.Size = new System.Drawing.Size(334, 21);
            this.CbHeartRateOutlineStyle.TabIndex = 20;
            this.CbHeartRateOutlineStyle.SelectedIndexChanged += new System.EventHandler(this.CbHeartRateOutlineStyle_SelectedIndexChanged);
            // 
            // NudHeartRateFontSize
            // 
            this.NudHeartRateFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudHeartRateFontSize.Location = new System.Drawing.Point(98, 72);
            this.NudHeartRateFontSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudHeartRateFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NudHeartRateFontSize.Name = "NudHeartRateFontSize";
            this.NudHeartRateFontSize.Size = new System.Drawing.Size(71, 20);
            this.NudHeartRateFontSize.TabIndex = 19;
            this.NudHeartRateFontSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudHeartRateFontSize.ValueChanged += new System.EventHandler(this.NudFontSize_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(6, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Font Size:";
            // 
            // BuHeartRateThresholdColor
            // 
            this.BuHeartRateThresholdColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuHeartRateThresholdColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuHeartRateThresholdColor.Location = new System.Drawing.Point(365, 147);
            this.BuHeartRateThresholdColor.Name = "BuHeartRateThresholdColor";
            this.BuHeartRateThresholdColor.Size = new System.Drawing.Size(67, 20);
            this.BuHeartRateThresholdColor.TabIndex = 17;
            this.BuHeartRateThresholdColor.Text = "Select";
            this.BuHeartRateThresholdColor.UseVisualStyleBackColor = true;
            this.BuHeartRateThresholdColor.Click += new System.EventHandler(this.BuHeartRateThresholdColor_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(6, 150);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Threshold Above Color:";
            // 
            // TbHeartRateThresholdColor
            // 
            this.TbHeartRateThresholdColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbHeartRateThresholdColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbHeartRateThresholdColor.Location = new System.Drawing.Point(130, 147);
            this.TbHeartRateThresholdColor.Name = "TbHeartRateThresholdColor";
            this.TbHeartRateThresholdColor.ReadOnly = true;
            this.TbHeartRateThresholdColor.Size = new System.Drawing.Size(203, 20);
            this.TbHeartRateThresholdColor.TabIndex = 15;
            // 
            // NudHeartRateThreshold
            // 
            this.NudHeartRateThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudHeartRateThreshold.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudHeartRateThreshold.Location = new System.Drawing.Point(98, 121);
            this.NudHeartRateThreshold.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NudHeartRateThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudHeartRateThreshold.Name = "NudHeartRateThreshold";
            this.NudHeartRateThreshold.Size = new System.Drawing.Size(71, 20);
            this.NudHeartRateThreshold.TabIndex = 14;
            this.NudHeartRateThreshold.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NudHeartRateThreshold.ValueChanged += new System.EventHandler(this.NudHeartRateThreshold_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(6, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Threshold BPM:";
            // 
            // CbHeartRateThresholdChange
            // 
            this.CbHeartRateThresholdChange.AutoSize = true;
            this.CbHeartRateThresholdChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbHeartRateThresholdChange.Location = new System.Drawing.Point(9, 98);
            this.CbHeartRateThresholdChange.Name = "CbHeartRateThresholdChange";
            this.CbHeartRateThresholdChange.Size = new System.Drawing.Size(149, 17);
            this.CbHeartRateThresholdChange.TabIndex = 12;
            this.CbHeartRateThresholdChange.Text = "Change color by threshold";
            this.CbHeartRateThresholdChange.UseVisualStyleBackColor = true;
            this.CbHeartRateThresholdChange.CheckedChanged += new System.EventHandler(this.CbHeartRateThresholdChange_CheckedChanged);
            // 
            // BuHeartRateColor
            // 
            this.BuHeartRateColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuHeartRateColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuHeartRateColor.Location = new System.Drawing.Point(365, 19);
            this.BuHeartRateColor.Name = "BuHeartRateColor";
            this.BuHeartRateColor.Size = new System.Drawing.Size(67, 20);
            this.BuHeartRateColor.TabIndex = 11;
            this.BuHeartRateColor.Text = "Select";
            this.BuHeartRateColor.UseVisualStyleBackColor = true;
            this.BuHeartRateColor.Click += new System.EventHandler(this.BuHeartRateColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "HeartRate Color:";
            // 
            // TbHeartRateColor
            // 
            this.TbHeartRateColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbHeartRateColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbHeartRateColor.Location = new System.Drawing.Point(130, 19);
            this.TbHeartRateColor.Name = "TbHeartRateColor";
            this.TbHeartRateColor.ReadOnly = true;
            this.TbHeartRateColor.Size = new System.Drawing.Size(203, 20);
            this.TbHeartRateColor.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TbServerAddress);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.NudServerPort);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Info";
            // 
            // TbServerAddress
            // 
            this.TbServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbServerAddress.Location = new System.Drawing.Point(60, 44);
            this.TbServerAddress.Name = "TbServerAddress";
            this.TbServerAddress.ReadOnly = true;
            this.TbServerAddress.Size = new System.Drawing.Size(372, 20);
            this.TbServerAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address:";
            // 
            // NudServerPort
            // 
            this.NudServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudServerPort.Location = new System.Drawing.Point(60, 18);
            this.NudServerPort.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
            this.NudServerPort.Name = "NudServerPort";
            this.NudServerPort.Size = new System.Drawing.Size(63, 20);
            this.NudServerPort.TabIndex = 1;
            this.NudServerPort.Value = new decimal(new int[] {
            10110,
            0,
            0,
            0});
            this.NudServerPort.ValueChanged += new System.EventHandler(this.NudServerPort_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TbVolume);
            this.groupBox4.Controls.Add(this.CbAutoShowPreview);
            this.groupBox4.Controls.Add(this.CbSoundAlert);
            this.groupBox4.Controls.Add(this.CbHideAtStart);
            this.groupBox4.Controls.Add(this.CbServerAutostart);
            this.groupBox4.Controls.Add(this.CbRetryConnect);
            this.groupBox4.Controls.Add(this.CbAutoConnectAtStart);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 236);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "App Settings";
            // 
            // TbVolume
            // 
            this.TbVolume.AutoSize = false;
            this.TbVolume.LargeChange = 10;
            this.TbVolume.Location = new System.Drawing.Point(188, 134);
            this.TbVolume.Maximum = 100;
            this.TbVolume.Minimum = 10;
            this.TbVolume.Name = "TbVolume";
            this.TbVolume.Size = new System.Drawing.Size(104, 17);
            this.TbVolume.TabIndex = 6;
            this.TbVolume.TickFrequency = 10;
            this.TbVolume.Value = 10;
            this.TbVolume.Scroll += new System.EventHandler(this.TbVolume_Scroll);
            // 
            // CbAutoShowPreview
            // 
            this.CbAutoShowPreview.AutoSize = true;
            this.CbAutoShowPreview.Checked = true;
            this.CbAutoShowPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAutoShowPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbAutoShowPreview.Location = new System.Drawing.Point(6, 111);
            this.CbAutoShowPreview.Name = "CbAutoShowPreview";
            this.CbAutoShowPreview.Size = new System.Drawing.Size(189, 17);
            this.CbAutoShowPreview.TabIndex = 5;
            this.CbAutoShowPreview.Text = "Show preview when server started";
            this.CbAutoShowPreview.UseVisualStyleBackColor = true;
            this.CbAutoShowPreview.CheckedChanged += new System.EventHandler(this.CbAutoShowPreview_CheckedChanged);
            // 
            // CbSoundAlert
            // 
            this.CbSoundAlert.AutoSize = true;
            this.CbSoundAlert.Checked = true;
            this.CbSoundAlert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbSoundAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbSoundAlert.Location = new System.Drawing.Point(6, 134);
            this.CbSoundAlert.Name = "CbSoundAlert";
            this.CbSoundAlert.Size = new System.Drawing.Size(176, 17);
            this.CbSoundAlert.TabIndex = 4;
            this.CbSoundAlert.Text = "Sound alert when disconnected";
            this.CbSoundAlert.UseVisualStyleBackColor = true;
            this.CbSoundAlert.CheckedChanged += new System.EventHandler(this.CbSoundAlert_CheckedChanged);
            // 
            // CbHideAtStart
            // 
            this.CbHideAtStart.AutoSize = true;
            this.CbHideAtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbHideAtStart.Location = new System.Drawing.Point(6, 19);
            this.CbHideAtStart.Name = "CbHideAtStart";
            this.CbHideAtStart.Size = new System.Drawing.Size(115, 17);
            this.CbHideAtStart.TabIndex = 3;
            this.CbHideAtStart.Text = "Hide to tray at start";
            this.CbHideAtStart.UseVisualStyleBackColor = true;
            this.CbHideAtStart.CheckedChanged += new System.EventHandler(this.CbHideAtStart_CheckedChanged);
            // 
            // CbServerAutostart
            // 
            this.CbServerAutostart.AutoSize = true;
            this.CbServerAutostart.Checked = true;
            this.CbServerAutostart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbServerAutostart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbServerAutostart.Location = new System.Drawing.Point(6, 88);
            this.CbServerAutostart.Name = "CbServerAutostart";
            this.CbServerAutostart.Size = new System.Drawing.Size(198, 17);
            this.CbServerAutostart.TabIndex = 2;
            this.CbServerAutostart.Text = "Start server when device connected";
            this.CbServerAutostart.UseVisualStyleBackColor = true;
            this.CbServerAutostart.CheckedChanged += new System.EventHandler(this.CbServerAutostart_CheckedChanged);
            // 
            // CbRetryConnect
            // 
            this.CbRetryConnect.AutoSize = true;
            this.CbRetryConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbRetryConnect.Location = new System.Drawing.Point(6, 65);
            this.CbRetryConnect.Name = "CbRetryConnect";
            this.CbRetryConnect.Size = new System.Drawing.Size(192, 17);
            this.CbRetryConnect.TabIndex = 1;
            this.CbRetryConnect.Text = "Retry connect when failed (5 times)";
            this.CbRetryConnect.UseVisualStyleBackColor = true;
            this.CbRetryConnect.CheckedChanged += new System.EventHandler(this.CbRetryConnect_CheckedChanged);
            // 
            // CbAutoConnectAtStart
            // 
            this.CbAutoConnectAtStart.AutoSize = true;
            this.CbAutoConnectAtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbAutoConnectAtStart.Location = new System.Drawing.Point(6, 42);
            this.CbAutoConnectAtStart.Name = "CbAutoConnectAtStart";
            this.CbAutoConnectAtStart.Size = new System.Drawing.Size(148, 17);
            this.CbAutoConnectAtStart.TabIndex = 0;
            this.CbAutoConnectAtStart.Text = "Connect to device at start";
            this.CbAutoConnectAtStart.UseVisualStyleBackColor = true;
            this.CbAutoConnectAtStart.CheckedChanged += new System.EventHandler(this.CbAutoConnectAndHide_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.TbLog);
            this.groupBox5.Controls.Add(this.LbLog);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(294, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(176, 146);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log";
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbLog.Location = new System.Drawing.Point(6, 19);
            this.TbLog.Name = "TbLog";
            this.TbLog.ReadOnly = true;
            this.TbLog.Size = new System.Drawing.Size(164, 20);
            this.TbLog.TabIndex = 4;
            // 
            // LbLog
            // 
            this.LbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbLog.FormattingEnabled = true;
            this.LbLog.Location = new System.Drawing.Point(6, 45);
            this.LbLog.Name = "LbLog";
            this.LbLog.Size = new System.Drawing.Size(164, 95);
            this.LbLog.TabIndex = 0;
            this.LbLog.Click += new System.EventHandler(this.LbLog_Click);
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
            this.niTray.Click += new System.EventHandler(this.NiTray_Click);
            // 
            // tiClose
            // 
            this.tiClose.Interval = 1000;
            this.tiClose.Tick += new System.EventHandler(this.TiClose_Tick);
            // 
            // tiHideOnStart
            // 
            this.tiHideOnStart.Interval = 1000;
            this.tiHideOnStart.Tick += new System.EventHandler(this.TiHideOnStart_Tick);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.showPreviewWindowToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.dONATEToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(482, 24);
            this.msMenu.TabIndex = 6;
            this.msMenu.Text = "Menu";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSettingsToolStripMenuItem,
            this.importSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appToolStripMenuItem.Text = "App";
            // 
            // exportSettingsToolStripMenuItem
            // 
            this.exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            this.exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportSettingsToolStripMenuItem.Text = "Export Settings";
            this.exportSettingsToolStripMenuItem.Click += new System.EventHandler(this.ExportSettingsToolStripMenuItem_Click);
            // 
            // importSettingsToolStripMenuItem
            // 
            this.importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            this.importSettingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importSettingsToolStripMenuItem.Text = "Import Settings";
            this.importSettingsToolStripMenuItem.Click += new System.EventHandler(this.ImportSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.getDeviceInfoToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // getDeviceInfoToolStripMenuItem
            // 
            this.getDeviceInfoToolStripMenuItem.Name = "getDeviceInfoToolStripMenuItem";
            this.getDeviceInfoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.getDeviceInfoToolStripMenuItem.Text = "Get Device Info";
            this.getDeviceInfoToolStripMenuItem.Click += new System.EventHandler(this.GetDeviceInfoToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // showPreviewWindowToolStripMenuItem
            // 
            this.showPreviewWindowToolStripMenuItem.Name = "showPreviewWindowToolStripMenuItem";
            this.showPreviewWindowToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.showPreviewWindowToolStripMenuItem.Text = "Show Preview Window";
            this.showPreviewWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowPreviewWindowToolStripMenuItem_Click_1);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.myTwitchChannelToolStripMenuItem,
            this.addSuggestionsOrIssueToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.gitHubToolStripMenuItem.Text = "Project on GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // myTwitchChannelToolStripMenuItem
            // 
            this.myTwitchChannelToolStripMenuItem.Name = "myTwitchChannelToolStripMenuItem";
            this.myTwitchChannelToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.myTwitchChannelToolStripMenuItem.Text = "GoodVrGames Twitch";
            this.myTwitchChannelToolStripMenuItem.Click += new System.EventHandler(this.MyTwitchChannelToolStripMenuItem_Click);
            // 
            // addSuggestionsOrIssueToolStripMenuItem
            // 
            this.addSuggestionsOrIssueToolStripMenuItem.Name = "addSuggestionsOrIssueToolStripMenuItem";
            this.addSuggestionsOrIssueToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addSuggestionsOrIssueToolStripMenuItem.Text = "Add Suggestions or Issue";
            this.addSuggestionsOrIssueToolStripMenuItem.Click += new System.EventHandler(this.AddSuggestionsOrIssueToolStripMenuItem_Click);
            // 
            // dONATEToolStripMenuItem
            // 
            this.dONATEToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen;
            this.dONATEToolStripMenuItem.Name = "dONATEToolStripMenuItem";
            this.dONATEToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.dONATEToolStripMenuItem.Text = "DONATE";
            this.dONATEToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.TabMain);
            this.tabControl.Controls.Add(this.TabSettings);
            this.tabControl.Controls.Add(this.TabOutput);
            this.tabControl.Controls.Add(this.TabHeartRate);
            this.tabControl.Controls.Add(this.TabChart);
            this.tabControl.Controls.Add(this.TabAnimation);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(458, 271);
            this.tabControl.TabIndex = 7;
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.groupBox1);
            this.TabMain.Controls.Add(this.groupBox3);
            this.TabMain.Location = new System.Drawing.Point(4, 22);
            this.TabMain.Name = "TabMain";
            this.TabMain.Padding = new System.Windows.Forms.Padding(3);
            this.TabMain.Size = new System.Drawing.Size(450, 245);
            this.TabMain.TabIndex = 0;
            this.TabMain.Text = "Main";
            this.TabMain.UseVisualStyleBackColor = true;
            // 
            // TabSettings
            // 
            this.TabSettings.Controls.Add(this.groupBox4);
            this.TabSettings.Location = new System.Drawing.Point(4, 22);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettings.Size = new System.Drawing.Size(450, 245);
            this.TabSettings.TabIndex = 1;
            this.TabSettings.Text = "Settings";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // TabOutput
            // 
            this.TabOutput.Controls.Add(this.groupBox2);
            this.TabOutput.Location = new System.Drawing.Point(4, 22);
            this.TabOutput.Name = "TabOutput";
            this.TabOutput.Size = new System.Drawing.Size(450, 245);
            this.TabOutput.TabIndex = 2;
            this.TabOutput.Text = "Output";
            this.TabOutput.UseVisualStyleBackColor = true;
            // 
            // TabHeartRate
            // 
            this.TabHeartRate.Controls.Add(this.gbHeartRateSettings);
            this.TabHeartRate.Location = new System.Drawing.Point(4, 22);
            this.TabHeartRate.Name = "TabHeartRate";
            this.TabHeartRate.Size = new System.Drawing.Size(450, 245);
            this.TabHeartRate.TabIndex = 3;
            this.TabHeartRate.Text = "Heart Rate";
            this.TabHeartRate.UseVisualStyleBackColor = true;
            // 
            // TabChart
            // 
            this.TabChart.Controls.Add(this.gbChartSettings);
            this.TabChart.Location = new System.Drawing.Point(4, 22);
            this.TabChart.Name = "TabChart";
            this.TabChart.Size = new System.Drawing.Size(450, 245);
            this.TabChart.TabIndex = 4;
            this.TabChart.Text = "Chart";
            this.TabChart.UseVisualStyleBackColor = true;
            // 
            // TabAnimation
            // 
            this.TabAnimation.Controls.Add(this.gbAnimationSettings);
            this.TabAnimation.Location = new System.Drawing.Point(4, 22);
            this.TabAnimation.Name = "TabAnimation";
            this.TabAnimation.Size = new System.Drawing.Size(450, 245);
            this.TabAnimation.TabIndex = 5;
            this.TabAnimation.Text = "Animation";
            this.TabAnimation.UseVisualStyleBackColor = true;
            // 
            // cbTestMode
            // 
            this.cbTestMode.AutoSize = true;
            this.cbTestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTestMode.Location = new System.Drawing.Point(9, 147);
            this.cbTestMode.Name = "cbTestMode";
            this.cbTestMode.Size = new System.Drawing.Size(169, 17);
            this.cbTestMode.TabIndex = 20;
            this.cbTestMode.Text = "Test Mode (60 bpm for output)";
            this.cbTestMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 462);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
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
            ((System.ComponentModel.ISupportInitialize)(this.PbMinMaxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChartLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChartDotsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudChartWidth)).EndInit();
            this.gbAnimationSettings.ResumeLayout(false);
            this.gbAnimationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnimSpeedMultiplier)).EndInit();
            this.gbHeartRateSettings.ResumeLayout(false);
            this.gbHeartRateSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbHeartRateThresholdColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHeartRateColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeartRateFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeartRateThreshold)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudServerPort)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbVolume)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.TabSettings.ResumeLayout(false);
            this.TabOutput.ResumeLayout(false);
            this.TabHeartRate.ResumeLayout(false);
            this.TabChart.ResumeLayout(false);
            this.TabAnimation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox TbServerAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown NudServerPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox CbRetryConnect;
		private System.Windows.Forms.CheckBox CbAutoConnectAtStart;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox TbLog;
		private System.Windows.Forms.ListBox LbLog;
		private System.Windows.Forms.GroupBox gbHeartRateSettings;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TbHeartRateColor;
		private System.Windows.Forms.TextBox TbMinMaxColor;
		private System.Windows.Forms.TextBox TbLineColor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown NudChartDotsCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColorDialog cdSelectColor;
		private System.Windows.Forms.GroupBox gbChartSettings;
		private System.Windows.Forms.NumericUpDown NudChartWidth;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox gbAnimationSettings;
		private System.Windows.Forms.Button BuAnimationClear;
		private System.Windows.Forms.Button BuAnimationSelect;
		private System.Windows.Forms.TextBox TbAnimationPath;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox CbOutputOrientation;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox CbOutputMode;
		private System.Windows.Forms.Button BuHeartRateColor;
		private System.Windows.Forms.Button BuMinMaxColor;
		private System.Windows.Forms.Button BuLineColor;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox TbObsWidth;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox CbServerAutostart;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.OpenFileDialog ofdSelectAnimation;
		private System.Windows.Forms.TextBox TbDeviceName;
		private System.Windows.Forms.TextBox TbDeviceBattery;
		private System.Windows.Forms.TextBox TbDeviceStatus;
		private System.Windows.Forms.TextBox TbDeviceId;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NotifyIcon niTray;
		private System.Windows.Forms.Timer tiClose;
		private System.Windows.Forms.Timer tiHideOnStart;
		private System.Windows.Forms.NumericUpDown NudAnimSpeedMultiplier;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox TbAnimFilter;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button BuOpenFilterPage;
		private System.Windows.Forms.Button BuOpenCssFontPage;
		private System.Windows.Forms.TextBox TbFontFamily;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.CheckBox CbChartLineSmooth;
		private System.Windows.Forms.NumericUpDown NudChartLineThickness;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox CbHideAtStart;
		private System.Windows.Forms.CheckBox CbSoundAlert;
		private System.Windows.Forms.Button BuHeartRateThresholdColor;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox TbHeartRateThresholdColor;
		private System.Windows.Forms.NumericUpDown NudHeartRateThreshold;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.CheckBox CbHeartRateThresholdChange;
		private System.Windows.Forms.MenuStrip msMenu;
		private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getDeviceInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem myTwitchChannelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addSuggestionsOrIssueToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown NudHeartRateFontSize;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckBox CbAutoShowPreview;
		private System.Windows.Forms.ToolStripMenuItem showPreviewWindowToolStripMenuItem;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox CbHeartRateOutlineStyle;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage TabMain;
		private System.Windows.Forms.TabPage TabSettings;
		private System.Windows.Forms.TabPage TabOutput;
		private System.Windows.Forms.TabPage TabHeartRate;
		private System.Windows.Forms.TabPage TabChart;
		private System.Windows.Forms.TabPage TabAnimation;
		private System.Windows.Forms.PictureBox PbHeartRateColor;
		private System.Windows.Forms.PictureBox PbMinMaxColor;
		private System.Windows.Forms.PictureBox PbLineColor;
		private System.Windows.Forms.PictureBox PbHeartRateThresholdColor;
        private System.Windows.Forms.Button BuCalculateMultiplier;
        private System.Windows.Forms.TrackBar TbVolume;
        private System.Windows.Forms.ToolStripMenuItem dONATEToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbTestMode;
    }
}

