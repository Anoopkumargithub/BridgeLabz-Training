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
        
        static void ModifyValue(int number)
        {
           number = 100;
        }
        
        tatic void ModifyReference(Citizen citizen)
        {
           citizen.UpdateProfile("updated@email.com", "New Address 123456");
        }
    }
}
