using TechVille.Application.Services;
using TechVille.Domain.Entities;
using TechVille.Domain.Enums;


namespace TechVille.ConsoleUI.Menus
{
    /// <summary>
    /// Handles multi-member citizen registration session.
    /// </summary>
    public class RegistrationMenu
    {
        private readonly CitizenRegistrationService _service;

        public RegistrationMenu()
        {
            _service = new CitizenRegistrationService();
        }

        public void Start()
        {
            Console.Write("How many family members to register? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"\nRegistering Member {i}");

                try
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Invalid name. Skipping...");
                        continue; // continue example
                    }

                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());

                    if (age <= 0)
                    {
                        Console.WriteLine("Invalid age. Skipping...");
                        continue;
                    }

                    Console.Write("Enter Income: ");
                    double income = double.Parse(Console.ReadLine());

                    Console.Write("Enter Residency Years: ");
                    int residency = int.Parse(Console.ReadLine());

                    Citizen citizen = _service.Register(name, age, income, residency);

                    Console.WriteLine("Registration Successful!");
                    Console.WriteLine(citizen);
                    

                    // Ternary operator example
                    string seniorStatus = age >= 60 ? "Senior Citizen" : "Non-Senior";
                    Console.WriteLine($"Status: {seniorStatus}");

                    ShowPackageBenefits(citizen.Package.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");

                    Console.Write("Stop registration? (y/n): ");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "y")
                        break; // break example
                }
            }
        }

        private void ShowPackageBenefits(ServicePackage package)
        {
            switch (package)
            {
                case "Basic":
                    Console.WriteLine("Access to essential city services.");
                    break;

                case "Silver":
                    Console.WriteLine("Priority service support.");
                    break;

                case "Gold":
                    Console.WriteLine("Premium healthcare and education benefits.");
                    break;

                case "Platinum":
                    Console.WriteLine("All-inclusive VIP access.");
                    break;

                default:
                    Console.WriteLine("Invalid package.");
                    break;
            }
        }

    }
}
