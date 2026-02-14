using System;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class DoctorMenu
    {
        private readonly DoctorService _doctorService;

        public DoctorMenu(DoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== DOCTOR MANAGEMENT (ADMIN) =====");
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
                    case "1": _doctorService.AddDoctor(); break;
                    case "2": _doctorService.UpdateDoctor(); break;
                    case "3": _doctorService.GetDoctorById(); break;
                    case "4": _doctorService.GetDoctorsBySpeciality(); break;
                    case "5": _doctorService.DeleteDoctor(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }
    }
}
