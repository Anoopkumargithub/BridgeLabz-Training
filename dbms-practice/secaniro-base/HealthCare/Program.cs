using System;
using HealthCare.Service;
using HealthCare.Menu;

class Program
{
    static void Main()
    {
        PatientMenu patientMenu = new PatientMenu();
        DoctorMenu doctorMenu = new DoctorMenu();

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
                    patientMenu.Show();
                    break;

                case "2":
                    doctorMenu.Show();
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
