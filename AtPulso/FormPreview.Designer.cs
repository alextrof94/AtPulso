
namespace AtPulso
{
	partial class FormPreview
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreview));
			this.cwbPreview = new CefSharp.WinForms.ChromiumWebBrowser();
			this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// cwbPreview
			// 
			this.cwbPreview.ActivateBrowserOnCreation = false;
			this.cwbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cwbPreview.ContextMenuStrip = this.cMenu;
			this.cwbPreview.Location = new System.Drawing.Point(0, 0);
			this.cwbPreview.Name = "cwbPreview";
			this.cwbPreview.Size = new System.Drawing.Size(800, 150);
			this.cwbPreview.TabIndex = 0;
			this.cwbPreview.TabStop = false;
			this.cwbPreview.LoadError += new System.EventHandler<CefSharp.LoadErrorEventArgs>(this.cwbPreview_LoadError);
			this.cwbPreview.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.cwbPreview_LoadingStateChanged);
			this.cwbPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPreview_MouseDown);
			this.cwbPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPreview_MouseMove);
			this.cwbPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormPreview_MouseUp);
			// 
			// cMenu
			// 
			this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.cMenu.Name = "cMenu";
			this.cMenu.Size = new System.Drawing.Size(181, 92);
			// 
			// backgroundToolStripMenuItem
			// 
			this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.chessToolStripMenuItem});
			this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
			this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.backgroundToolStripMenuItem.Text = "Background";
			// 
			// whiteToolStripMenuItem
			// 
			this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
			this.whiteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.whiteToolStripMenuItem.Text = "White";
			this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
			// 
			// grayToolStripMenuItem
			// 
			this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
			this.grayToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.grayToolStripMenuItem.Text = "Gray";
			this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
			// 
			// blackToolStripMenuItem
			// 
			this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
			this.blackToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.blackToolStripMenuItem.Text = "Black";
			this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
			// 
			// chessToolStripMenuItem
			// 
			this.chessToolStripMenuItem.Name = "chessToolStripMenuItem";
			this.chessToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.chessToolStripMenuItem.Text = "Chess";
			this.chessToolStripMenuItem.Click += new System.EventHandler(this.chessToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.closeToolStripMenuItem.Text = "Hide Preview";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// FormPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 150);
			this.Controls.Add(this.cwbPreview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormPreview";
			this.Text = "AtPulso - Preview";
			this.Shown += new System.EventHandler(this.FormPreview_Shown);
			this.cMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private CefSharp.WinForms.ChromiumWebBrowser cwbPreview;
		private System.Windows.Forms.ContextMenuStrip cMenu;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
	}
}