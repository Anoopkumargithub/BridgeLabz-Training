using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_access_modifiers
{
    internal class Book
    {
        // public variable
        public string ISBN;

        // protected variable
        protected string title;

        // private variable
        private string author;

        // Constructor
        public Book(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        // Public method to set author
        public void SetAuthor(string authorName)
        {
            author = authorName;
        }

        // Public method to get author
        public string GetAuthor()
        {
            return author;
        }

        // Instance Method
        public void DisplayBookDetails()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }

    // Subclass
    internal class EBook : Book
    {
        private double fileSize;

        public EBook(string ISBN, string title, string author, double fileSize)
            : base(ISBN, title, author)
        {
            this.fileSize = fileSize;
        }

        // Accessing public and protected members
        public void DisplayEBookDetails()
        {
            Console.WriteLine("ISBN: " + ISBN);       // public
            Console.WriteLine("Title: " + title);     // protected
            Console.WriteLine("File Size: " + fileSize + " MB");
        }
    }

    class LibraryManagement
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("978-0131103627", "Clean Code", "Robert C. Martin");

            Console.WriteLine("Book Details:");
            b1.DisplayBookDetails();
            Console.WriteLine();

            // Modify private author using public methods
            b1.SetAuthor("Uncle Bob");
            Console.WriteLine("Updated Author: " + b1.GetAuthor());
            Console.WriteLine();

            EBook eb1 =
                new EBook("978-0201616224", "The Pragmatic Programmer", "Andrew Hunt", 5.6);

            Console.WriteLine("EBook Details:");
            eb1.DisplayEBookDetails();
        }
    }
}
