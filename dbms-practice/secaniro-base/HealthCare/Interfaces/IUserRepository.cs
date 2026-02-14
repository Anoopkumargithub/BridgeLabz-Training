using System;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface IUserRepository
    {

        void CreateUser(User user);

        User GetByUsername(string username);
    }
}
