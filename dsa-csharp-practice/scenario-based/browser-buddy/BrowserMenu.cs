using System;

class BrowserMenu
{
    private IHistory history;

    public BrowserMenu()
    {
        history = new HistoryManipulationImpl();
    }

    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            System.Console.WriteLine("\n----Browser Buddy Menu----");
            System.Console.WriteLine("1. New Tab");
            System.Console.WriteLine("2. Next Tab");
            System.Console.WriteLine("3. Previous Tab");
            System.Console.WriteLine("4. Close Tab");
            System.Console.WriteLine("5. Reopen Tab");
            System.Console.WriteLine("6. Exit");
            System.Console.Write("Enter your choice (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    history.NewTab();
                    break;
                case "2":
                    history.NextTab();
                    break;
                case "3":
                    history.PrevTab();
                    break;
                case "4":
                    history.CloseTab();
                    break;
                case "5":
                    history.ReopenTab();
                    break;
                case "6":
                    running = false;
                    System.Console.WriteLine("Exiting Browser Buddy. Goodbye!");
                    break;
                default:
                    System.Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}