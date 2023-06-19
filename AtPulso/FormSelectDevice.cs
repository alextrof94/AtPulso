using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtPulso.Utils.Schema;
using AtPulso.Utils.Events;
using System.Collections.Specialized;
using AtPulso.Utils;
using System.Diagnostics;

namespace AtPulso
{
	public partial class FormSelectDevice : Form
	{
		public ObservableCollection<WatcherDevice> devices = new ObservableCollection<WatcherDevice>();
		public string selectedDeviceId = "";

		private HeartDeviceWatcher _pairedWatcher;

		public FormSelectDevice()
		{
			InitializeComponent();
		}

		private void FormSelectDevice_Shown(object sender, EventArgs e)
		{
			devices.CollectionChanged += devicesChanged;

			_pairedWatcher = new HeartDeviceWatcher(DeviceSelector.BluetoothLePairedOnly);
			_pairedWatcher.DeviceAdded += OnPaired_DeviceAdded;
			_pairedWatcher.DeviceRemoved += OnPaired_DeviceRemoved;
			_pairedWatcher.Start();
		}

		private void devicesChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			lbDevices.Invoke((MethodInvoker)delegate {
				lbDevices.Items.Clear();
				foreach (var device in devices)
					lbDevices.Items.Add(device.Name);
			});
		}

		private void buConnect_Click(object sender, EventArgs e)
		{
			if (lbDevices.SelectedIndex > -1)
			{
				var selectedItem = devices[lbDevices.SelectedIndex];
				if (selectedItem != null)
				{
					selectedDeviceId = selectedItem.Id;
					DialogResult = DialogResult.OK;
					Close();
				}
			}
		}

		private void OnPaired_DeviceAdded(object sender, DeviceAddedEventArgs e)
		{
			devices.Add(e.Device);
			Debug.WriteLine("Paired Device Added: " + e.Device.Id);
		}

		private void OnPaired_DeviceRemoved(object sender, DeviceRemovedEventArgs e)
		{
			var foundItem = devices.FirstOrDefault(a => a.Id == e.Device.Id);
			if (foundItem != null)
				devices.Remove(foundItem);
			Debug.WriteLine("Paired device Removed: " + e.Device.Id);
		}
	}
}
