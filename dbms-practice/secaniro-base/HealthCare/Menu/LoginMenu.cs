using System;
using HealthCare.Models;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class LoginMenu
    {
        private readonly UserService _userService;

        public LoginMenu(UserService userService)
        {
            _userService = userService;
        }

        public User Show()
        {
            Console.WriteLine("\n===== LOGIN =====");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            User user = _userService.Login(username, password);

            if (user == null)
            {
                Console.WriteLine("Invalid credentials.");
                return null;
            }

            Console.WriteLine($"Welcome {user.Username} ({user.Role})");
            return user;
        }
    }
}
