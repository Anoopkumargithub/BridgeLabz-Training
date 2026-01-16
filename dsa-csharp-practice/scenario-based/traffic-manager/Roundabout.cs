using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.traffic_manager
{
    internal class Roundabout
    {
        private Vehicle tail;

        public void AddVehicle(string number)
        {
            Vehicle newVehicle = new Vehicle(number);

            if (tail == null)
            {
                tail = newVehicle;
                tail.Next = tail;
            }
            else
            {
                newVehicle.Next = tail.Next;
                tail.Next = newVehicle;
                tail = newVehicle;
            }

            Console.WriteLine("Vehicle entered roundabout");
        }

        public void RemoveVehicle()
        {
            if (tail == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }

            if (tail.Next == tail)
            {
                Console.WriteLine("Vehicle exited: " + tail.VehicleNumber);
                tail = null;
            }
            else
            {
                Vehicle head = tail.Next;
                Console.WriteLine("Vehicle exited: " + head.VehicleNumber);
                tail.Next = head.Next;
            }
        }

        public void Display()
        {
            if (tail == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }

            Vehicle current = tail.Next;
            Console.Write("Roundabout: ");
            do
            {
                Console.Write(current.VehicleNumber);
                current = current.Next;
            } while (current != tail.Next);

            Console.WriteLine("(back to start)");
        }
    }
}
