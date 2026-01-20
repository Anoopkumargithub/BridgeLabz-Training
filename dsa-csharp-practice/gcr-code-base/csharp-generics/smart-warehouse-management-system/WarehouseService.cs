using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.smart_warehouse_management_system
{
    internal class WarehouseService : IWarehouseService
    {
        private Storage<WarehouseItem> storage = new Storage<WarehouseItem>();

        public void AddElectronics()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Warranty (years): ");
            int warranty = int.Parse(Console.ReadLine());

            storage.AddItem(new Electronics(name, price, warranty));
        }

        public void AddGroceries()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Expiry Date: ");
            string expiry = Console.ReadLine();

            storage.AddItem(new Groceries(name, price, expiry));
        }

        public void AddFurniture()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Material: ");
            string material = Console.ReadLine();

            storage.AddItem(new Furniture(name, price, material));
        }

        public void DisplayItems()
        {
            Console.WriteLine("\n--- Warehouse Items ---");
            foreach (var item in storage.GetAllItems())
            {
                Console.WriteLine(item.GetDetails());
            }
        }
    }
}
