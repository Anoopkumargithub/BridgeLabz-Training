using System;

class Menu
{
    private IBook book;

    public Menu()
    {
        book = new IBookImpl();
    }

    public void DisplayMenu()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("   Welcome to BookBuddy System");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Search Books by Author");
        Console.WriteLine("3. Sort Books Alphabetically");
        Console.WriteLine("4. Display All Books");
        Console.WriteLine("5. Exit");
        Console.WriteLine("=======================================");
        Console.Write("Enter your choice: ");
    }

    public void Run()
    {
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    SearchByAuthor();
                    break;
                case "3":
                    SortBooks();
                    break;
                case "4":
                    DisplayBooks();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Thank you for using BookBuddy!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    private void AddBook()
    {
        Console.WriteLine("\n--- Add Book ---");
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        try
        {
            book.addBook(new Book(title, author));
            Console.WriteLine("Book added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error adding book: " + ex.Message);
        }
    }

    private void SearchByAuthor()
    {
        Console.WriteLine("\n--- Search by Author ---");
        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        try
        {
            Console.WriteLine("\nBooks by " + author + ":");
            book.searchByAuthor(author);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void SortBooks()
    {
        Console.WriteLine("\n--- Sort Books Alphabetically ---");
        try
        {
            book.sortBookByAlphabetically();
            Console.WriteLine("Books sorted successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sorting books: " + ex.Message);
        }
    }

    private void DisplayBooks()
    {
        Console.WriteLine("\n--- All Books ---");
        try
        {
            book.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error displaying books: " + ex.Message);
        }
    }
}
