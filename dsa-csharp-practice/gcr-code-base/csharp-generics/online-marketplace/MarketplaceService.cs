using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.online_marketplace
{
    internal class MarketplaceService : IMarketplaceService
    {
        private List<object> catalog = new List<object>();

        // Generic Method with Constraint
        private void ApplyDiscount<T>(Product<T> product, double percentage)
            where T : ICategory
        {
            product.Price -= product.Price * (percentage / 100);
        }

        public void AddBook()
        {
            Console.Write("Book Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            var book = new Product<BookCategory>(name, price, new BookCategory());
            catalog.Add(book);
        }

        public void AddClothing()
        {
            Console.Write("Clothing Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            var cloth = new Product<ClothingCategory>(name, price, new ClothingCategory());
            catalog.Add(cloth);
        }

        public void ApplyDiscountToAll(double percentage)
        {
            foreach (var item in catalog)
            {
                if (item is Product<BookCategory> book)
                    ApplyDiscount(book, percentage);

                else if (item is Product<ClothingCategory> cloth)
                    ApplyDiscount(cloth, percentage);
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\n--- Product Catalog ---");
            foreach (var item in catalog)
            {
                Console.WriteLine(item);
            }
        }
    }
}
