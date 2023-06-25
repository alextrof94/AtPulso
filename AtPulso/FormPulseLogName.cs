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
	public partial class FormPulseLogName : Form
	{
		public string LogName { get; set; }
		public DateTime Start { get; set; }

		public FormPulseLogName()
		{
			InitializeComponent();
		}

		private void FormPulseLogName_Shown(object sender, EventArgs e)
		{
			tpStart.Value = Start;
			tbName.Text = Start.ToShortDateString();
		}
	}
}
