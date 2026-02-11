using System;
using HealthCare.Menu;

namespace HealthCare.Menu
{
    public class AdminMenu
    {
        private readonly DoctorMenu _doctorMenu;
        private readonly SpecialityMenu _specialityMenu;

        public AdminMenu()
        {
            _doctorMenu = new DoctorMenu();
            _specialityMenu = new SpecialityMenu();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== ADMIN PANEL =====");
                Console.WriteLine("1. Manage Doctors");
                Console.WriteLine("2. Manage Specialities");
                Console.WriteLine("0. Back");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _doctorMenu.Show();
                        break;

                    case "2":
                        _specialityMenu.Show();
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
