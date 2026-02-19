using TechVille.Application.Services;
using TechVille.Domain.Entities;

namespace TechVille.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TechVille Citizen Registration ===");

            try
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Income: ");
                double income = double.Parse(Console.ReadLine());

                Console.Write("Enter Residency Years: ");
                int residency = int.Parse(Console.ReadLine());

                CitizenRegistrationService service = new CitizenRegistrationService();
                Citizen citizen = service.Register(name, age, income, residency);

                Console.WriteLine("\nRegistration Successful!");
                Console.WriteLine(citizen);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
