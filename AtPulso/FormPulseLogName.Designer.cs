
namespace AtPulso
{
	partial class FormPulseLogName
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
			this.tbName = new System.Windows.Forms.TextBox();
			this.tpStart = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.buSave = new System.Windows.Forms.Button();
			this.buClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name of log:";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(110, 12);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(202, 20);
			this.tbName.TabIndex = 1;
			// 
			// tpStart
			// 
			this.tpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tpStart.Location = new System.Drawing.Point(110, 38);
			this.tpStart.Name = "tpStart";
			this.tpStart.Size = new System.Drawing.Size(202, 20);
			this.tpStart.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Stream started:";
			// 
			// buSave
			// 
			this.buSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buSave.Location = new System.Drawing.Point(157, 64);
			this.buSave.Name = "buSave";
			this.buSave.Size = new System.Drawing.Size(155, 21);
			this.buSave.TabIndex = 4;
			this.buSave.Text = "Save";
			this.buSave.UseVisualStyleBackColor = true;
			// 
			// buClear
			// 
			this.buClear.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.buClear.Location = new System.Drawing.Point(15, 64);
			this.buClear.Name = "buClear";
			this.buClear.Size = new System.Drawing.Size(136, 23);
			this.buClear.TabIndex = 5;
			this.buClear.Text = "Clear without save";
			this.buClear.UseVisualStyleBackColor = true;
			// 
			// FormPulseLogName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 97);
			this.Controls.Add(this.buClear);
			this.Controls.Add(this.buSave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tpStart);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPulseLogName";
			this.Text = "AtPulso - Save Heartrate Log";
			this.Shown += new System.EventHandler(this.FormPulseLogName_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.DateTimePicker tpStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buSave;
		private System.Windows.Forms.Button buClear;
	}
}