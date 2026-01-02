using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class BusRouteDistanceTracker
    {
        public static void Main(string[] args)
        {
            int stopNumber = 1;
            double totalDistance = 0;
            double distancePerStop = 2.5;
            string userChoice = "no";

            Console.WriteLine("Bus Route Distance Tracker Started");
            Console.WriteLine();

            while (userChoice != "yes")
            {
                Console.WriteLine("Stop No: " + stopNumber);
                totalDistance = totalDistance + distancePerStop;

                Console.WriteLine("Distance added: " + distancePerStop + " km");
                Console.WriteLine("Total Distance Covered: " + totalDistance + " km");

                Console.WriteLine("Do you want to get off at this stop? (yes/no)");
                userChoice = Console.ReadLine().ToLower();

                stopNumber++;
                Console.WriteLine();
            }

            Console.WriteLine("Passenger got off the bus.");
            Console.WriteLine("Total Distance Travelled: " + totalDistance + " km");
            Console.WriteLine("Thank you for travelling");
        }
    }
}