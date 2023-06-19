
namespace AtPulso
{
	partial class FormSelectDevice
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
			this.lbDevices = new System.Windows.Forms.ListBox();
			this.buConnect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbDevices
			// 
			this.lbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDevices.FormattingEnabled = true;
			this.lbDevices.Location = new System.Drawing.Point(12, 12);
			this.lbDevices.Name = "lbDevices";
			this.lbDevices.Size = new System.Drawing.Size(253, 225);
			this.lbDevices.TabIndex = 0;
			// 
			// buConnect
			// 
			this.buConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buConnect.Location = new System.Drawing.Point(12, 249);
			this.buConnect.Name = "buConnect";
			this.buConnect.Size = new System.Drawing.Size(253, 23);
			this.buConnect.TabIndex = 1;
			this.buConnect.Text = "Connect";
			this.buConnect.UseVisualStyleBackColor = true;
			this.buConnect.Click += new System.EventHandler(this.buConnect_Click);
			// 
			// FormSelectDevice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 284);
			this.Controls.Add(this.buConnect);
			this.Controls.Add(this.lbDevices);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormSelectDevice";
			this.Text = "AtPulso - Select Device";
			this.Shown += new System.EventHandler(this.FormSelectDevice_Shown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbDevices;
		private System.Windows.Forms.Button buConnect;
	}
}