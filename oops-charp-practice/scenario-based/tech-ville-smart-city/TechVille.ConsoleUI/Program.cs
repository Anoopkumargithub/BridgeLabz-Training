using TechVille.ConsoleUI.Menus;
using TechVille.Domain.Entities;

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

            Console.WriteLine("\n=== City Services Demo ===");

Service healthcare = new HealthcareService(5000m, true);
Service education = new EducationService(3000m, "Higher");

healthcare.DescribeService();
Console.WriteLine();
education.DescribeService();
        }
        
        static void ModifyValue(int number)
        {
           number = 100;
        }

        static void ModifyReference(Citizen citizen)
        {
           citizen.UpdateProfile("updated@email.com", "New Address 123456");
        }
    }
}
