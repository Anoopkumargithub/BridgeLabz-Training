using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_constructors
{
    internal class BookClass
    {
        private string title;
        private string author;
        private double price;

        public BookClass(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine($"{title} is written by {author} by INR {price}");
        }
    }
    public class Program()
    {
        public static void Main(string[] args)
        {
            string title = "Adam's Family";
            string author = "Adam Carter";
            double price = 250.0;

            BookClass book = new BookClass(title, author, price);

            book.Display();

        }
    }
}
