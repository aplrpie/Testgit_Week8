using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{
    internal class ElectricKettle : ISwitchControl, IPowerConsumption
    {
        private bool _isOn = false;
        private bool _isBoiling = false;
        private int _temperature = 25;

        public bool isOn
        {
            get { return _isOn; }
            set { _isOn = value; }
        }

        public int PowerUsage { get; } = 1500;

        public void TurnOn()
        {
            if (!_isOn)
            {
                _isOn = true;
                Console.WriteLine("Kettle turned ON. Starting to heat water...");
                StartBoiling();
            }
        }

        public void TurnOff()
        {
            _isOn = false;
            _isBoiling = false;
            Console.WriteLine("Kettle turned OFF. Heating stopped.");
        }

        private void StartBoiling()
        {
            _isBoiling = true;
            for (int i = 0; i <= 100; i += 25)
            {
                _temperature = i;
                Console.WriteLine($"Water temperature: {_temperature}°C");
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("💨 Water is boiling! Kettle will turn off automatically.");
            TurnOff();
        }

        public void ShowPowerUsage()
        {
            Console.WriteLine($"This electric kettle consumes {PowerUsage} watts of power.");
        }
    }
}
