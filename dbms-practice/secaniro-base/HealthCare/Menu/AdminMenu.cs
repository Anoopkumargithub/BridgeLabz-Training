using System;
using HealthCare.Menu;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class AdminMenu
    {
        private readonly DoctorMenu _doctorMenu;
        private readonly SpecialityMenu _specialityMenu;
        private readonly UserService _userService;

        public AdminMenu(DoctorService doctorService, UserService userService)
        {
            _doctorMenu = new DoctorMenu(doctorService);
            _specialityMenu = new SpecialityMenu();
            _userService = userService;
        }

        public bool Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== ADMIN PANEL =====");
                Console.WriteLine("1. Manage Doctors");
                Console.WriteLine("2. Manage Specialities");
                Console.WriteLine("3. Create User");
                Console.WriteLine("0. Logout");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": _doctorMenu.Show(); break;
                    case "2": _specialityMenu.Show(); break;
                    case "3": _userService.CreateUser(); break;
                    case "0": return true;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }
    }
}
