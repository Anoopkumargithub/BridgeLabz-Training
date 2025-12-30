using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class LibraryManagementSystem
    {
        enum Role
        {
            Administrator = 1,
            User = 2
        }

        // ---------------- ROLE SELECTION ----------------
        static Role SelectRole()
        {
            Console.WriteLine("Select Role:");
            Console.WriteLine("1. Administrator");
            Console.WriteLine("2. User");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice == 1 ? Role.Administrator : Role.User;
        }

        // ---------------- READ BOOKS ----------------
        static string[,] ReadBook()
        {
            Console.WriteLine("Enter number of books:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[,] book = new string[n, 3];
            // [Title, Author, Availability]

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}");

                Console.Write("Book Name: ");
                book[i, 0] = Console.ReadLine();

                Console.Write("Author Name: ");
                book[i, 1] = Console.ReadLine();

                Console.Write("Availability (0 = Available, 1 = Not Available): ");
                string status = Console.ReadLine();
                book[i, 2] = (status == "0") ? "0" : "1";
            }
            return book;
        }

        // ---------------- DISPLAY BOOKS ----------------
        static void DisplayBook(string[,] book)
        {
            Console.WriteLine("Book Name || Author Name || Availability");

            for (int i = 0; i < book.GetLength(0); i++)
            {
                Console.Write($"{book[i, 0]} || {book[i, 1]} || ");
                Console.WriteLine(book[i, 2] == "0" ? "Available" : "Not Available");
            }
        }

        // ---------------- SEARCH BY TITLE ----------------
        static void SearchBookByTitle(string[,] book)
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine().ToLower();
            bool found = false;

            Console.WriteLine("Book Name || Author Name || Availability");

            for (int i = 0; i < book.GetLength(0); i++)
            {
                if (book[i, 0].ToLower().Contains(title))
                {
                    found = true;
                    Console.Write($"{book[i, 0]} || {book[i, 1]} || ");
                    Console.WriteLine(book[i, 2] == "0" ? "Available" : "Not Available");
                }
            }

            if (!found)
                Console.WriteLine("No book found with this title.");
        }

        // ---------------- SEARCH BY AUTHOR ----------------
        static void SearchByAuthor(string[,] book)
        {
            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine().ToLower();
            bool found = false;

            Console.WriteLine("Book Name || Author Name || Availability");

            for (int i = 0; i < book.GetLength(0); i++)
            {
                if (book[i, 1].ToLower().Contains(author))
                {
                    found = true;
                    Console.Write($"{book[i, 0]} || {book[i, 1]} || ");
                    Console.WriteLine(book[i, 2] == "0" ? "Available" : "Not Available");
                }
            }

            if (!found)
                Console.WriteLine("No books found for this author.");
        }

        // ---------------- CHECK AVAILABILITY ----------------
        static void CheckAvailability(string[,] book)
        {
            Console.Write("Enter Book Name: ");
            string name = Console.ReadLine().ToLower();
            bool found = false;

            for (int i = 0; i < book.GetLength(0); i++)
            {
                if (book[i, 0].ToLower().Contains(name))
                {
                    found = true;
                    Console.WriteLine(book[i, 2] == "0"
                        ? "Book is Available"
                        : "Book is Not Available");
                }
            }

            if (!found)
                Console.WriteLine("Book not found.");
        }

        // ---------------- CHECKOUT BOOK ----------------
        static void Checkout(string[,] book)
        {
            Console.Write("Enter Book Name: ");
            string name = Console.ReadLine().ToLower();
            bool found = false;

            for (int i = 0; i < book.GetLength(0); i++)
            {
                if (book[i, 0].ToLower().Contains(name))
                {
                    found = true;
                    if (book[i, 2] == "0")
                    {
                        book[i, 2] = "1";
                        Console.WriteLine("Book checked out successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Book is already checked out.");
                    }
                }
            }

            if (!found)
                Console.WriteLine("Book not found.");
        }

        // ---------------- OPERATIONS ----------------
        static int Operations(ref string[,] book, Role role)
        {
            Console.WriteLine("Choose Operation:");

            if (role == Role.Administrator)
                Console.WriteLine("1. Add Books");

            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Search Book by Title");
            Console.WriteLine("4. Search Book by Author");
            Console.WriteLine("5. Check Availability");
            Console.WriteLine("6. Checkout Book");
            Console.WriteLine("7. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (role == Role.Administrator)
                        book = ReadBook();
                    else
                        Console.WriteLine("Access Denied.");
                    break;

                case 2: DisplayBook(book); break;
                case 3: SearchBookByTitle(book); break;
                case 4: SearchByAuthor(book); break;
                case 5: CheckAvailability(book); break;
                case 6: Checkout(book); break;
                case 7: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid Option."); break;
            }
            return choice;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Library Management System ===");

            Role role = SelectRole();
            string[,] book = ReadBook();

            while (true)
            {
                int option = Operations(ref book, role);
                if (option == 7)
                    break;
            }
        }
    }
}
