using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{
    internal interface IBluetoothConnect
    {
        bool IsConnected { get; set; }
        void ConnectDevice(string deviceName);
        void DisconnectDevice();
    }
}
