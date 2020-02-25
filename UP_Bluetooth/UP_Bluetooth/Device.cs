using InTheHand.Net;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Bluetooth
{
    class Device
    {
        // Odpowiednie propercje charakteryzujace urzadzenie
        public string DeviceName { get; set; }
        public bool Authenticated { get; set; }
        public bool Connected { get; set; }
        public ushort Nap { get; set; }
        public uint Sap { get; set; }
        public BluetoothAddress DeviceInfo { get; set; }
        public DateTime LastSeen { get; set; }
        public DateTime LastUsed { get; set; }
        public bool Remembered { get; set; }

        /// <summary>
        /// Konstruktor klasy Device
        /// </summary>
        /// <param name="device_info"></param>
        public Device(BluetoothDeviceInfo device_info)
        {
            this.Authenticated = device_info.Authenticated;
            this.DeviceInfo = device_info.DeviceAddress;
            this.Connected = device_info.Connected;
            this.DeviceName = device_info.DeviceName;
            this.LastSeen = device_info.LastSeen;
            this.LastUsed = device_info.LastUsed;
            this.Nap = device_info.DeviceAddress.Nap;
            this.Sap = device_info.DeviceAddress.Sap;
            this.Remembered = device_info.Remembered;
        }

        public override string ToString()
        {
            return this.DeviceName;
        }
    }
}
