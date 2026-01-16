using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.traffic_manager
{
    internal class Vehicle
    {
        public string VehicleNumber { get; private set; }
        public Vehicle Next { get; set; }

        public Vehicle(string number)
        {
            VehicleNumber = number;
            Next = null;
        }

        public override string ToString()
        {
            return VehicleNumber;
        }
    }
}
