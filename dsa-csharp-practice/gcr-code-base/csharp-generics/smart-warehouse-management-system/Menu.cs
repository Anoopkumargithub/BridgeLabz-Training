using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal class Menu
    {
        private IWarehouseService service;

        public Menu()
        {
            service = new WarehouseService(); // upcasting
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Smart Warehouse Menu ---");
                Console.WriteLine("1. Add Electronics");
                Console.WriteLine("2. Add Groceries");
                Console.WriteLine("3. Add Furniture");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddElectronics();
                        break;
                    case 2:
                        service.AddGroceries();
                        break;
                    case 3:
                        service.AddFurniture();
                        break;
                    case 4:
                        service.DisplayItems();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
