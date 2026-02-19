using TechVille.ConsoleUI.Menus;

namespace TechVille.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TechVille Service Eligibility System ===");

            RegistrationMenu menu = new RegistrationMenu();
            menu.Start();

            Console.WriteLine("\nSession Completed.");
            Console.ReadLine();
        }
    }
}
