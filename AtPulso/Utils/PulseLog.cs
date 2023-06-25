using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtPulso.Utils
{
	struct PulseLogItem
	{
		public DateTime date;
		public int bpm;
		public PulseLogItem(DateTime newDate, int newBpm)
		{
			date = newDate;
			bpm = newBpm;
		}
	};

	class PulseLog
	{
		public List<PulseLogItem> log { get; private set; }
		public bool haveUnsavedData { get; private set; }

		public PulseLog()
		{
			log = new List<PulseLogItem>();
			haveUnsavedData = false;
		}

		public void Add(int newVal)
		{
			if (log.Last().bpm != newVal)
			{
				log.Add(new PulseLogItem(DateTime.UtcNow, newVal));
				haveUnsavedData = true;
			}
		}

		public void Save()
		{
			FormPulseLogName pln = new FormPulseLogName();
			pln.Start = log.First().date;
			var dr = pln.ShowDialog();
			if (dr == System.Windows.Forms.DialogResult.OK)
			{
				// TODO: save
				log.Clear();
				haveUnsavedData = false;
			} else if (dr == System.Windows.Forms.DialogResult.Abort)
			{
				log.Clear();
				haveUnsavedData = false;
			}
		}
	}
}
