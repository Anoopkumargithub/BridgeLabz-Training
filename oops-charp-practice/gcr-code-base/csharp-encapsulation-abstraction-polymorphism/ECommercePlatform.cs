using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism
{
        // Interface
        internal interface ITaxable
        {
            double CalculateTax();
            string GetTaxDetails();
        }

        // Abstract Class
        internal abstract class Product
        {
            private int productId;
            private string name;
            private double price;

            public int ProductId
            {
                get { return productId; }
            }

            public string Name
            {
                get { return name; }
            }

            public double Price
            {
                get { return price; }
            }

            protected Product(int productId, string name, double price)
            {
                this.productId = productId;
                this.name = name;
                this.price = price;
            }

            // Setter to update price (encapsulation)
            public void UpdatePrice(double price)
            {
                this.price = price;
            }

            public abstract double CalculateDiscount();

            public double GetFinalPrice()
            {
                double tax = 0;

                if (this is ITaxable)
                {
                    tax = ((ITaxable)this).CalculateTax();
                }

                return price + tax - CalculateDiscount();
            }

            public void DisplayProduct()
            {
                Console.WriteLine("Product ID: " + productId);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Base Price: INR " + price);

                if (this is ITaxable)
                {
                    Console.WriteLine(((ITaxable)this).GetTaxDetails());
                }

                Console.WriteLine("Discount: INR " + CalculateDiscount());
                Console.WriteLine("Final Price: INR " + GetFinalPrice());
                Console.WriteLine("-------------------------");
            }
        }

        // Electronics
        internal class Electronics : Product, ITaxable
        {
            public Electronics(int id, string name, double price)
                : base(id, name, price) { }

            public override double CalculateDiscount()
            {
                return Price * 0.10;
            }

            public double CalculateTax()
            {
                return Price * 0.18;
            }

            public string GetTaxDetails()
            {
                return "Electronics Tax: 18%";
            }
        }

        // Clothing
        internal class Clothing : Product, ITaxable
        {
            public Clothing(int id, string name, double price)
                : base(id, name, price) { }

            public override double CalculateDiscount()
            {
                return Price * 0.20;
            }

            public double CalculateTax()
            {
                return Price * 0.05;
            }

            public string GetTaxDetails()
            {
                return "Clothing Tax: 5%";
            }
        }

        // Groceries (No Tax)
        internal class Groceries : Product
        {
            public Groceries(int id, string name, double price)
                : base(id, name, price) { }

            public override double CalculateDiscount()
            {
                return Price * 0.05;
            }
        }

        // Utility Class
        internal class ProductUtility
        {
            private Product[] products;
            private int count;

            public ProductUtility(int size)
            {
                products = new Product[size];
                count = 0;
            }

            public void AddProduct(Product product)
            {
                if (count < products.Length)
                {
                    products[count++] = product;
                }
            }

            public void DisplayFinalPrices()
            {
                for (int i = 0; i < count; i++)
                {
                    products[i].DisplayProduct();
                }
            }
        }

        // Main Class
        internal class ECommercePlatform
        {
        static void Main(string[] args)
            {
                ProductUtility utility = new ProductUtility(5);

                Product p1 = new Electronics(101, "Laptop", 60000);
                Product p2 = new Clothing(102, "Jacket", 4000);
                Product p3 = new Groceries(103, "Rice Bag", 1200);

                utility.AddProduct(p1);
                utility.AddProduct(p2);
                utility.AddProduct(p3);

                utility.DisplayFinalPrices();
            }

    }
}
