using AtPulso.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtPulso
{
	public partial class FormPreview : Form
	{
		public Form1 parent;
		public string address = "";
		public int width = 400;
		public int bgIndex = 0;

		private bool mouseDown;
		private Point lastLocation;

		TransparentPanel panel = new TransparentPanel();

		public FormPreview()
		{
			InitializeComponent();
			panel.Parent = this;
			panel.Left = 0;
			panel.Top = 0;
			panel.Visible = true;
			panel.MouseDown += FormPreview_MouseDown;
			panel.MouseMove += FormPreview_MouseMove;
			panel.MouseUp += FormPreview_MouseUp;
			this.Controls.Add(panel);
		}

		public void UpdateWidth()
		{
			Width = width;
			panel.Width = Width;
			panel.Height = Height;
			if (!string.IsNullOrEmpty(address))
			{
				cwbPreview.LoadUrlAsync(address);
			}
			panel.BringToFront();
		}

		private void FormPreview_Shown(object sender, EventArgs e)
		{
			UpdateWidth();
		}


		private void FormPreview_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				mouseDown = true;
				lastLocation = e.Location;
			}
		}

		private void FormPreview_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown && e.Button == MouseButtons.Left)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

		private void FormPreview_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				mouseDown = false;
			} else if (e.Button == MouseButtons.Right)
			{
				cMenu.Show(panel, e.Location);
			}
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateWidth();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
		}


		private void changeBackground()
		{
			string str;
			switch (bgIndex)
			{
				case 0: str = "document.body.style.background = 'white'; document.body.classList.remove('chess');"; break;
				case 1: str = "document.body.style.background = 'gray'; document.body.classList.remove('chess');"; break;
				case 2: str = "document.body.style.background = 'black'; document.body.classList.remove('chess');"; break;
				default: str = "document.body.style.background = ''; document.body.classList.add('chess');"; break;
			}
			cwbPreview.GetBrowser().MainFrame.ExecuteJavaScriptAsync(str);
		}

		private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bgIndex = 0;
			parent.UpdateBackgroundSetting(bgIndex);
			changeBackground();
		}

		private void grayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bgIndex = 1;
			parent.UpdateBackgroundSetting(bgIndex);
			changeBackground();
		}

		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bgIndex = 2;
			parent.UpdateBackgroundSetting(bgIndex);
			changeBackground();
		}

		private void chessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bgIndex = 3;
			parent.UpdateBackgroundSetting(bgIndex);
			changeBackground();

		}

		private void cwbPreview_IsBrowserInitializedChanged(object sender, EventArgs e)
		{
		}

		private void cwbPreview_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
		{
			if (!e.IsLoading)
				changeBackground();
		}

		private void cwbPreview_LoadError(object sender, CefSharp.LoadErrorEventArgs e)
		{
			// empty
		}
	}
}
