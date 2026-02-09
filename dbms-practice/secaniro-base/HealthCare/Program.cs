using System;
using HealthCare.Service;

class Program
{
    static void Main()
    {
        PatientService service = new PatientService();

        while (true)
        {
            Console.WriteLine("\n===== HEALTHCARE SYSTEM =====");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Update Patient");
            Console.WriteLine("3. Search Patient");
            Console.WriteLine("4. Get Patient By ID");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    service.AddPatient();
                    break;

                case "2":
                    service.UpdatePatient();
                    break;

                case "3":
                    service.SearchPatient();
                    break;

                case "4":
                    service.GetPatientById();
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
