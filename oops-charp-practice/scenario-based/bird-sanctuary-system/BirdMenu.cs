using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.bird_sanctuary_system
{
    internal class BirdMenu
    {
        private BirdUtility utility;

        public BirdMenu(BirdUtility utility)
        {
            this.utility = utility;
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Bird Sanctuary Menu ---");
                Console.WriteLine("1. Add Eagle");
                Console.WriteLine("2. Add Sparrow");
                Console.WriteLine("3. Add Duck");
                Console.WriteLine("4. Add Penguin");
                Console.WriteLine("5. Add Seagull");
                Console.WriteLine("6. Show Bird Activities");
                Console.WriteLine("7. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBird(new Eagle("Eagle"));
                        break;
                    case 2:
                        AddBird(new Sparrow("Sparrow"));
                        break;
                    case 3:
                        AddBird(new Duck("Duck"));
                        break;
                    case 4:
                        AddBird(new Penguin("Penguin"));
                        break;
                    case 5:
                        AddBird(new Seagull("Seagull"));
                        break;
                    case 6:
                        utility.ShowBirdActivities();
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 7);
        }

        private void AddBird(Bird bird)
        {
            utility.AddBird(bird);
        }
    }
}
