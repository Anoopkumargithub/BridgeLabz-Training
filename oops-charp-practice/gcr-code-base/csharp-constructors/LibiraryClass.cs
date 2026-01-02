using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_constructors
{
    internal class LibiraryClass
    {
        private string title;
        private string author;
        private double price;
        private bool availabitly;

        public LibiraryClass(string title, string author, double price, bool availabitly)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availabitly = availabitly;
        }

        public void Availability()
        {
            if (this.availabitly)
            {
                this.availabitly = false;
                Display();
            }
            else
            {
                Console.WriteLine("Book Not Available");
            }
        }

        public void Display()
        {
            Console.Write($"{title} is written by {author} by INR {price}");
        }
    }
    public class Program()
    {
        public static void Main(string[] args)
        {
            string title = "Adam's Family";
            string author = "Adam Carter";
            double price = 250.0;

            LibiraryClass book1 = new LibiraryClass(title, author, price, true);
            LibiraryClass book2 = new LibiraryClass("Star", "Carter", 265.0, false);
            Console.WriteLine("Which Book you want to borrow: ");
            Console.Write("1.");
            book1.Display();
            Console.WriteLine();
            Console.Write("2.");
            book2.Display();
            Console.WriteLine();
            int borrow = int.Parse(Console.ReadLine());
            switch (borrow)
            {
                case 1:
                    {
                        book1.Availability();
                        break;
                    }
                case 2:
                    {
                        book2.Availability();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }
    }
}
