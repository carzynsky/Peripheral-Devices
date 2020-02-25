using InTheHand.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_Bluetooth
{
    class SendModule
    {
        public static void SendFile(BluetoothAddress address, string file_path)
        {
            var uri = new Uri("obex://" + address + "/" + file_path);
            var request = new ObexWebRequest(uri);
            request.ReadFile(file_path);
            var response = (ObexWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusCode.ToString());
            // check response.StatusCode
            response.Close();
        }
    }
}
