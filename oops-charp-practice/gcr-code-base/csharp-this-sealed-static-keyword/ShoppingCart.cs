using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class Product
    {
        // Static Variable (shared discount)
        public static double Discount;

        // Instance Variables
        public string ProductName;
        public readonly int ProductID;
        public double Price;
        public int Quantity;

        public Product(string ProductName, int ProductID, double Price, int Quantity)
        {
            // using this keyword
            this.ProductName = ProductName;
            this.ProductID = ProductID;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public double CalculateFinalPrice()
        {
            double total = Price * Quantity;
            double discountAmount = total * Discount / 100;
            return total - discountAmount;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name   : " + ProductName);
            Console.WriteLine("Product ID     : " + ProductID);
            Console.WriteLine("Price          : INR " + Price);
            Console.WriteLine("Quantity       : " + Quantity);
            Console.WriteLine("Discount       : " + Discount + "%");
            Console.WriteLine("Final Amount   : INR " + CalculateFinalPrice());
        }

        // Static Method
        public static void UpdateDiscount(double discount)
        {
            Discount = discount;
        }
    }

    class ShoppingCart
    {
        public static void Main(string[] args)
        {
            Product.UpdateDiscount(10);

            Product p1 = new Product("Laptop", 1001, 55000, 1);
            Product p2 = new Product("Headphones", 1002, 3000, 2);

            Console.WriteLine("Product 1 Details:");
            if (p1 is Product)
            {
                p1.DisplayProductDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            if (p2 is Product)
            {
                p2.DisplayProductDetails();
            }
        }
    }
}
