using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.online_marketplace
{
    internal class Menu
    {
        private IMarketplaceService service;

        public Menu()
        {
            service = new MarketplaceService(); // upcasting
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Online Marketplace ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Clothing");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Display Products");
                Console.WriteLine("5. Exit");

                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddBook();
                        break;
                    case 2:
                        service.AddClothing();
                        break;
                    case 3:
                        Console.Write("Discount %: ");
                        double percent = double.Parse(Console.ReadLine());
                        service.ApplyDiscountToAll(percent);
                        break;
                    case 4:
                        service.DisplayProducts();
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
