using System;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class DoctorMenu
    {
        private readonly DoctorService _service;

        public DoctorMenu()
        {
            _service = new DoctorService();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== DOCTOR MENU =====");
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
                        _service.AddDoctor();
                        break;

                    case "2":
                        _service.UpdateDoctor();
                        break;

                    case "3":
                        _service.GetDoctorById();
                        break;

                    case "4":
                        _service.GetDoctorsBySpeciality();
                        break;

                    case "5":
                        _service.DeleteDoctor();
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
