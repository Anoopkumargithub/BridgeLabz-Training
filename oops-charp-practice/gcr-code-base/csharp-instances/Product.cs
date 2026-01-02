using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_instances
{
    internal class Product
    {
        private string productName;
        private double price;

        // Class Variable
        private static int totalProducts = 0;

        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        // Instance Method
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Price        : INR " + price);
        }

        // Class Method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products Created : " + totalProducts);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 55000);
            Product p2 = new Product("Mobile", 25000);
            Product p3 = new Product("Headphones", 3000);

            Console.WriteLine("Product 1 Details:");
            p1.DisplayProductDetails();
            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            p2.DisplayProductDetails();
            Console.WriteLine();

            Console.WriteLine("Product 3 Details:");
            p3.DisplayProductDetails();
            Console.WriteLine();

            Product.DisplayTotalProducts();
        }
    }
}
