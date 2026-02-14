using System;
using System.Security.Cryptography;
using System.Text;
using HealthCare.Interfaces;
using HealthCare.Models;

namespace HealthCare.Service
{
    public class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public void CreateUser()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
        
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
        
            Console.Write("Enter Role (ADMIN/DOCTOR/RECEPTIONIST): ");
            string role = Console.ReadLine().ToUpper();
        
            int? doctorId = null;
        
            if (role == "DOCTOR")
            {
                Console.Write("Enter DoctorID to link: ");
                doctorId = int.Parse(Console.ReadLine());
            }
        
            string hashedPassword = HashPassword(password);
        
            User newUser = new User
            {
                Username = username,
                PasswordHash = hashedPassword,
                Role = role,
                DoctorID = doctorId
            };
        
            _repo.CreateUser(newUser);
        
            Console.WriteLine("User created successfully.");
        }
        

        public User Login(string username, string password)
        {
            User user = _repo.GetByUsername(username);

            if (user == null)
                return null;

            string hashedInput = HashPassword(password);

            if (user.PasswordHash == hashedInput)
                return user;

            return null;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(
                    Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}
