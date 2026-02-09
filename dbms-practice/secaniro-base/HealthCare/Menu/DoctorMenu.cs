using System;
using HealthCare.Service;

namespace HealthCare.Menus
{
    public static class DoctorMenu
    {
        public static void Start()
        {
            DoctorService service = new DoctorService();

            while (true)
            {
                Console.WriteLine("\n===== DOCTOR MODULE =====");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Update Doctor");
                Console.WriteLine("3. Get Doctor By ID");
                Console.WriteLine("4. Get Doctors By Speciality");
                Console.WriteLine("5. Delete Doctor");
                Console.WriteLine("0. Back");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        service.AddDoctor();
                        break;

                    case "2":
                        service.UpdateDoctor();
                        break;

                    case "3":
                        service.GetDoctorById();
                        break;

                    case "4":
                        service.GetDoctorsBySpeciality();
                        break;

                    case "5":
                        service.DeleteDoctor();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
