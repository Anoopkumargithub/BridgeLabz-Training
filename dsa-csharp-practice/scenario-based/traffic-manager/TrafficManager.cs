using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.traffic_manager
{
    internal class TrafficManager
    {
        private Roundabout roundabout;
        private VehicleQueue queue;

        public TrafficManager()
        {
            roundabout = new Roundabout();
            queue = new VehicleQueue(5);
        }

        public void AddVehicleToQueue(string number)
        {
            queue.Enqueue(number);
        }

        public void MoveVehicleToRoundabout()
        {
            string vehicle = queue.Dequeue();
            if (vehicle != null)
                roundabout.AddVehicle(vehicle);
        }

        public void ExitVehicle()
        {
            roundabout.RemoveVehicle();
        }

        public void DisplayStatus()
        {
            queue.Display();
            roundabout.Display();
        }
    }
}
