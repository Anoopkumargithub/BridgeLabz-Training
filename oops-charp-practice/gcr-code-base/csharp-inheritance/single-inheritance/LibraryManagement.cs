using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_inheritance.single_inheritance
{
    // Superclass
    internal class Book
    {
        protected string Title;
        protected int PublicationYear;

        public Book(string Title, int PublicationYear)
        {
            this.Title = Title;
            this.PublicationYear = PublicationYear;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Book Title        : " + Title);
            Console.WriteLine("Publication Year : " + PublicationYear);
        }
    }

    // Subclass (Single Inheritance)
    internal class Author : Book
    {
        private string Name;
        private string Bio;

        public Author(string Title, int PublicationYear, string Name, string Bio)
            : base(Title, PublicationYear)
        {
            this.Name = Name;
            this.Bio = Bio;
        }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Author Name      : " + Name);
            Console.WriteLine("Author Bio       : " + Bio);
        }
    }

    class LibraryManagement
    {
        public static void Main(string[] args)
        {
            Author book1 = new Author(
                "Star",
                2026,
                "Jhon Carter",
                "Anime Lover"
            );

            Console.WriteLine("Book & Author Details:");
            book1.DisplayInfo();
        }
    }
}
