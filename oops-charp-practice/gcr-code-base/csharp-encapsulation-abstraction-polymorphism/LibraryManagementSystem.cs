using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism
{
    // Interface
    internal interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }

    // Abstract Class
    internal abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        // Sensitive borrower data (encapsulated)
        private string borrowerName;
        private bool isReserved;

        public int ItemId
        {
            get { return itemId; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        protected LibraryItem(int itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
            this.isReserved = false;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("Item ID: " + itemId);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
            Console.WriteLine("Availability: " + (isReserved ? "Reserved" : "Available"));
        }

        // Encapsulated methods for reservation
        protected void Reserve(string borrower)
        {
            borrowerName = borrower;
            isReserved = true;
        }

        protected bool IsReserved()
        {
            return isReserved;
        }
    }

    // Book Class
    internal class Book : LibraryItem, IReservable
    {
        public Book(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem(string borrowerName)
        {
            Reserve(borrowerName);
        }

        public bool CheckAvailability()
        {
            return !IsReserved();
        }
    }

    // Magazine Class
    internal class Magazine : LibraryItem, IReservable
    {
        public Magazine(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem(string borrowerName)
        {
            Reserve(borrowerName);
        }

        public bool CheckAvailability()
        {
            return !IsReserved();
        }
    }

    // DVD Class
    internal class DVD : LibraryItem, IReservable
    {
        public DVD(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem(string borrowerName)
        {
            Reserve(borrowerName);
        }

        public bool CheckAvailability()
        {
            return !IsReserved();
        }
    }

    // Utility Class (Array + Polymorphism)
    internal class LibraryUtility
    {
        private LibraryItem[] items;
        private int count;

        public LibraryUtility(int size)
        {
            items = new LibraryItem[size];
            count = 0;
        }

        public void AddItem(LibraryItem item)
        {
            if (count < items.Length)
            {
                items[count++] = item;
            }
        }

        public void DisplayAllItems()
        {
            for (int i = 0; i < count; i++)
            {
                items[i].GetItemDetails();
                Console.WriteLine("------------------------");
            }
        }
    }

    // Main Class
    internal class LibraryManagementSystem
    {
        static void Main(string[] args)
        {
            LibraryUtility library = new LibraryUtility(5);

            LibraryItem b1 = new Book(101, "Star", "Carter");
            LibraryItem m1 = new Magazine(102, "Adam's Family", "Adam");
            LibraryItem d1 = new DVD(103, "Stranger Things", "Duffer Brothers");

            // Polymorphic reservation
            ((IReservable)b1).ReserveItem("Anoop");

            library.AddItem(b1);
            library.AddItem(m1);
            library.AddItem(d1);

            library.DisplayAllItems();
        }
    }
}
