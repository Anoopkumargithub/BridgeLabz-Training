using System;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class SpecialityMenu
    {
        private readonly SpecialityService _service;

        public SpecialityMenu()
        {
            _service = new SpecialityService();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== SPECIALITY MENU =====");
                Console.WriteLine("1. Add Speciality");
                Console.WriteLine("2. View All Specialities");
                Console.WriteLine("3. Search Speciality");
                Console.WriteLine("0. Back");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _service.AddSpeciality();
                        break;

                    case "2":
                        _service.ShowAllSpecialities();
                        break;

                    case "3":
                        _service.SearchSpeciality();
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
