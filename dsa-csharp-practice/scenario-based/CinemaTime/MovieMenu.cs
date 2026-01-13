using System;

class MovieMenu
{

    private IMovie movieManager;

    public MovieMenu()
    {
        movie = new MovieImpl();
    }
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to Cinema Time!");
        Console.WriteLine("1. Add Movie");
        Console.WriteLine("2. Search Movies by Genre");
        Console.WriteLine("3. Sort Movies by Duration");
        Console.WriteLine("4. Display All Movies");
        Console.WriteLine("5. Exit");
    }

    public void Run()
    {
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Movie Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Movie Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Enter Movie Duration (in minutes): ");
                    int duration = int.Parse(Console.ReadLine());
                    Movie movie = new Movie(name, genre, duration);
                    movieManager.AddMovie(movie);
                    break;
                case "2":
                    Console.Write("Enter Genre to Search: ");
                    string searchGenre = Console.ReadLine();
                    movieManager.SearchByGenre(searchGenre);
                    break;
                case "3":
                    movieManager.SortMoviesByDuration();
                    break;
                case "4":
                    movieManager.Display();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Thank you for using Cinema Time!");
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
    
}