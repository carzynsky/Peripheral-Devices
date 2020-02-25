using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Sockets;
using InTheHand.Net;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.IO;
using InTheHand.Net;
using System.Threading;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;


namespace UP_Bluetooth
{
    public partial class FormMain : Form
    {
        public string FilePath { get; set; }
        List<Device> devices;

        /// <summary>
        /// Konstruktor klasy Form1
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        void findDevices()
        {
            List<Device> devices = new List<Device>();
            // po ponownym uruchomieniu
            if (comboBoxAvailableDevices.Items.Count > 0)
            {
                for(int i=0; i< comboBoxAvailableDevices.Items.Count; i++)
                comboBoxAvailableDevices.Items.RemoveAt(i);
            }

            InTheHand.Net.Sockets.BluetoothClient bc = new InTheHand.Net.Sockets.BluetoothClient();
            InTheHand.Net.Sockets.BluetoothDeviceInfo[] array = bc.DiscoverDevices();
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                Device device = new Device(array[i]);
                devices.Add(device);
                comboBoxAvailableDevices.Items.Add(device);
            }

            if(count > 0)
            {
                comboBoxAvailableDevices.SelectedIndex = 0;
                buttonPair.Enabled = buttonSearch.Enabled = buttonSend.Enabled = true;
                ShowDeviceOnScreen();

            }
        }
        private void buttonFindDevices_Click(object sender, EventArgs e)
        {
            findDevices();
        }

        public void ShowDeviceOnScreen()
        {
            Device device = (Device)comboBoxAvailableDevices.SelectedItem;
            textBoxDeviceName.Text = device.ToString();
            textBoxDeviceAddress.Text = device.DeviceInfo.ToString();
            if(device.Authenticated)
                textBoxdeviceAuthenticated.Text = "Tak";

            else
                textBoxdeviceAuthenticated.Text = "Nie";

            if (device.Connected)
                textBoxDeviceConnected.Text = "Połączony";
            else
                textBoxDeviceConnected.Text = "Niepołączony";
        }

        private void comboBoxAvailableDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDeviceOnScreen();
        }

        private void buttonPair_Click(object sender, EventArgs e)
        {
            Device device = (Device)comboBoxAvailableDevices.SelectedItem;
            BluetoothSecurity.PairRequest(device.DeviceInfo, null);
            findDevices();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Device device = (Device)comboBoxAvailableDevices.SelectedItem;
            SendModule.SendFile(device.DeviceInfo, FilePath);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog OFD = new System.Windows.Forms.OpenFileDialog();
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                FilePath = OFD.FileName;
            }

        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            ObexListener listener = new ObexListener();
            listener.Start();
            ObexListenerContext context = listener.GetContext();
            ObexListenerRequest request = context.Request;

            String[] pathSplits = request.RawUrl.Split('/');
            String filename = pathSplits[pathSplits.Length - 1];
            request.WriteFile(filename);
            listener.Stop();
        }
    }
}
