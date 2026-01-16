using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.traffic_manager
{
    internal class Menu
    {
        private TrafficManager manager = new TrafficManager();

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n--- Traffic Manager ---");
                Console.WriteLine("1. Vehicle Arrives");
                Console.WriteLine("2. Allow Vehicle into Roundabout");
                Console.WriteLine("3. Vehicle Exit Roundabout");
                Console.WriteLine("4. Display Traffic Status");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Vehicle Number: ");
                        manager.AddVehicleToQueue(Console.ReadLine());
                        break;

                    case 2:
                        manager.MoveVehicleToRoundabout();
                        break;

                    case 3:
                        manager.ExitVehicle();
                        break;

                    case 4:
                        manager.DisplayStatus();
                        break;

                    case 5:
                        return;
                }
            }
        }
    }
}
