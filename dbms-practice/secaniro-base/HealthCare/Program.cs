using System;
using HealthCare.Service;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== HEALTHCARE SYSTEM =====");
            Console.WriteLine("1. Patient Module");
            Console.WriteLine("2. Doctor Module");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PatientMenu.Start();
                    break;

                case "2":
                    DoctorMenu.Start();
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
