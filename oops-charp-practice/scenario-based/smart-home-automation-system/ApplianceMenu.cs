using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.smart_home_automation_system
{
    internal class ApplianceMenu
    {
        private ApplianceUtility utility;

        public ApplianceMenu(ApplianceUtility utility)
        {
            this.utility = utility;
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("--------Appliance Menu------");
                Console.WriteLine("1. Add Fan");
                Console.WriteLine("2. Add AC");
                Console.WriteLine("3. Add LightBulb");
                Console.WriteLine("4. Connected Appliance");
                Console.WriteLine("5. Exit");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddAppliance(new Appliance("Fan"));
                        break;

                    case 2:
                        AddAppliance(new Appliance("AC"));
                        break;

                    case 3:
                        AddAppliance(new Appliance("LightBulb"));
                        break;

                    case 4:
                        utility.ConnectedAppliance();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }
            } while (choice != 5);
        }

        private void AddAppliance(Appliance appliance)
        {
            utility.AddAppliance(appliance);
        }
    }
}
