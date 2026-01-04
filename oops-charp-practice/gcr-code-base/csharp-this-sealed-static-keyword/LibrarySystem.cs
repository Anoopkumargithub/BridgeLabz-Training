using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class Book
    {
        // Static Variable
        public static string LibraryName;

        // Instance Variables
        private string title;
        private string author;
        public readonly string ISBN;

        public Book(string title, string author, string ISBN)
        {
            // using this keyword
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Library Name : " + LibraryName);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("Author       : " + author);
            Console.WriteLine("ISBN         : " + ISBN);
        }

        // Static Method
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name : " + LibraryName);
        }
    }

    class LibrarySystem
    {
        public static void Main(string[] args)
        {
            Book.LibraryName = "Central City Library";

            Book book1 = new Book("Clean Code", "Robert C. Martin", "ISBN001");
            Book book2 = new Book("Atomic Habits", "James Clear", "ISBN002");

            Book.DisplayLibraryName();
            Console.WriteLine();

            Console.WriteLine("Book 1 Details:");
            if (book1 is Book)
            {
                book1.DisplayBookDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Book 2 Details:");
            if (book2 is Book)
            {
                book2.DisplayBookDetails();
            }
        }
    }
}
