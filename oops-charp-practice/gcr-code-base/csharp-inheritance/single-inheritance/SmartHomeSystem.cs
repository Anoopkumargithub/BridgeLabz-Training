using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_inheritance.single_inheritance
{
    // Superclass
    internal class Device
    {
        protected int DeviceId;
        protected string Status;

        public Device(int DeviceId, string Status)
        {
            this.DeviceId = DeviceId;
            this.Status = Status;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Device ID : " + DeviceId);
            Console.WriteLine("Status    : " + Status);
        }
    }

    // Subclass (Single Inheritance)
    internal class Thermostat : Device
    {
        private int TemperatureSetting;

        public Thermostat(int DeviceId, string Status, int TemperatureSetting)
            : base(DeviceId, Status)
        {
            this.TemperatureSetting = TemperatureSetting;
        }

        public void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Temperature Setting : " + TemperatureSetting + "C");
        }
    }

    class SmartHomeSystem
    {
        public static void Main(string[] args)
        {
            Thermostat t1 = new Thermostat(101, "ON", 24);

            Console.WriteLine("Smart Device Status:");
            t1.DisplayStatus();
        }
    }
}
