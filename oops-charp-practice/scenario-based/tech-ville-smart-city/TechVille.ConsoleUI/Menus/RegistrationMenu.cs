using TechVille.Application.Services;
using TechVille.Domain.Entities;
using TechVille.Domain.Enums;
using TechVille.Infrastructure.Logging;
using TechVille.Domain.Exceptions;


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

                    try
                    {
                        Citizen citizen = _service.Register(name, age, income,
                                                            residency, email, address);

                        Console.WriteLine("Registration Successful!");
                        Console.WriteLine(citizen);
                    }
                    catch (InvalidAgeException ex)
                    {
                        Console.WriteLine("Age validation failed.");
                        ExceptionLogger.Log(ex);
                    }
                    catch (InvalidEmailException ex)
                    {
                        Console.WriteLine("Email validation failed.");
                        ExceptionLogger.Log(ex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unexpected system error.");
                        ExceptionLogger.Log(ex);
                    }
                    catch (InvalidAgeException or InvalidEmailException ex)
                    {
                        Console.WriteLine("Validation error occurred.");
                        ExceptionLogger.Log(ex);
                    }
                    finally
                    {
                        Console.WriteLine("Processing completed.\n");
                    }

                    using (StreamWriter writer = new StreamWriter("audit.txt", true))
                    {
                        writer.WriteLine("Citizen registered.");
                    }

                    

                    // Ternary operator example
                    string seniorStatus = age >= 60 ? "Senior Citizen" : "Non-Senior";
                    Console.WriteLine($"Status: {seniorStatus}");

                    ShowPackageBenefits(citizen.Package);
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
                case ServicePackage.Basic:
                    Console.WriteLine("Access to essential city services.");
                    break;

                case ServicePackage.Silver:
                    Console.WriteLine("Priority service support.");
                    break;

                case ServicePackage.Gold:
                    Console.WriteLine("Premium healthcare and education benefits.");
                    break;

                case ServicePackage.Platinum:
                    Console.WriteLine("All-inclusive VIP access.");
                    break;
            }
        }


    }
}
