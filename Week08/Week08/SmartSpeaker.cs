using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{
    internal class SmartSpeaker : ISwitchControl, IPowerConsumption, IBluetoothConnect
    {
        private bool _isOn = false;
        private bool _isPlaying = false;

        public bool isOn
        {
            get { return _isOn; }
            set { _isOn = value; }
        }

        public int PowerUsage { get; } = 25;
        public bool IsConnected { get; set; } = false;
        public string ConnectedDeviceName { get; private set; }

        public void TurnOn()
        {
            if (!_isOn)
            {
                _isOn = true;
                Console.WriteLine("🔊 Smart Speaker turned ON. Ready to connect.");
            }
            else
            {
                Console.WriteLine("Speaker is already ON.");
            }
        }

        public void TurnOff()
        {
            _isOn = false;
            _isPlaying = false;
            IsConnected = false;
            Console.WriteLine("🔇 Smart Speaker turned OFF.");
        }

        public void ShowPowerUsage()
        {
            Console.WriteLine($"Smart Speaker consumes {PowerUsage} watts of power.");
        }

        public void ConnectDevice(string deviceName)
        {
            if (!_isOn)
            {
                Console.WriteLine("Cannot connect — speaker is OFF.");
                return;
            }

            IsConnected = true;
            ConnectedDeviceName = deviceName;
            Console.WriteLine($"📱 Connected to {deviceName} via Bluetooth.");
        }

        public void DisconnectDevice()
        {
            if (IsConnected)
            {
                Console.WriteLine($"Disconnected from {ConnectedDeviceName}.");
                IsConnected = false;
                ConnectedDeviceName = null;
            }
            else
            {
                Console.WriteLine("No device is currently connected.");
            }
        }

        public void PlayMusic(string songName)
        {
            if (!_isOn)
            {
                Console.WriteLine("Cannot play — speaker is OFF.");
                return;
            }

            if (!IsConnected)
            {
                Console.WriteLine("No Bluetooth device connected. Please connect first.");
                return;
            }

            _isPlaying = true;
            Console.WriteLine($"🎵 Now playing: {songName}");
        }
    }
}
