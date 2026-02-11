using System;
using HealthCare.Service;
using HealthCare.Menu;

class Program
{
    static void Main()
    {
        PatientMenu patientMenu = new PatientMenu();
        AdminMenu adminMenu = new AdminMenu();

        while (true)
        {
            Console.WriteLine("\n===== HEALTHCARE SYSTEM =====");
            Console.WriteLine("1. Patient Module");
            Console.WriteLine("2. Admin Panel");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    patientMenu.Show();
                    break;

                case "2":
                    adminMenu.Show();
                    break;

                case "0":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
