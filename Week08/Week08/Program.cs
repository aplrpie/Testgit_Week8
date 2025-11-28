using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ElectricKettle
            Console.WriteLine("\n=== ELECTRIC KETTLE ===");
            ElectricKettle kettle = new ElectricKettle();
            kettle.TurnOn();
            kettle.ShowPowerUsage();

            // SmartSpeaker
            Console.WriteLine("\n=== SMART SPEAKER ===");
            SmartSpeaker speaker = new SmartSpeaker();
            speaker.TurnOn();
            speaker.ShowPowerUsage();
            speaker.ConnectDevice("Kanakorn Phone");
            speaker.PlayMusic("Lookism OST - Fly High");
            speaker.DisconnectDevice();
            speaker.TurnOff();

            Console.WriteLine("\n=== END OF TEST ===");
            Console.ReadLine();
        }
    }
}