
namespace AtPulso
{
	partial class FormTurnLiveAuth
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buLogin = new System.Windows.Forms.Button();
			this.buInfo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login:";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(83, 12);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(236, 20);
			this.tbLogin.TabIndex = 1;
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(83, 38);
			this.tbPass.Name = "tbPass";
			this.tbPass.PasswordChar = '*';
			this.tbPass.Size = new System.Drawing.Size(236, 20);
			this.tbPass.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password:";
			// 
			// buLogin
			// 
			this.buLogin.Location = new System.Drawing.Point(122, 64);
			this.buLogin.Name = "buLogin";
			this.buLogin.Size = new System.Drawing.Size(197, 23);
			this.buLogin.TabIndex = 4;
			this.buLogin.Text = "Login";
			this.buLogin.UseVisualStyleBackColor = true;
			// 
			// buInfo
			// 
			this.buInfo.Location = new System.Drawing.Point(12, 65);
			this.buInfo.Name = "buInfo";
			this.buInfo.Size = new System.Drawing.Size(104, 23);
			this.buInfo.TabIndex = 5;
			this.buInfo.Text = "Info";
			this.buInfo.UseVisualStyleBackColor = true;
			// 
			// FormTurnLiveAuth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 100);
			this.Controls.Add(this.buInfo);
			this.Controls.Add(this.buLogin);
			this.Controls.Add(this.tbPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormTurnLiveAuth";
			this.Text = "AtPulso - Turnlive.ru Authorization";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buLogin;
		private System.Windows.Forms.Button buInfo;
	}
}