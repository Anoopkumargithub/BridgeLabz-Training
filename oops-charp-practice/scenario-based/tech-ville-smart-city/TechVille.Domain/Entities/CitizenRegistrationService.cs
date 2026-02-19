using TechVille.Domain.Entities;
using TechVille.Application.Utilities;
using TechVille.Domain.Exceptions;



namespace TechVille.Application.Services
{
    /// <summary>
    /// Handles citizen registration logic.
    /// </summary>
    public class CitizenRegistrationService
    {
        /// <summary>
        /// Registers a new citizen after validation.
        /// </summary>
        public Citizen Register(string name, int age, double income, int residencyYears, string email, string address)
        {
            // Basic validation using comparison operators
            if (age <= 0)
                throw new InvalidAgeException("Citizen must be 18 or older.");

            if (income < 0)
                throw new ArgumentException("Income cannot be negative.");

            if (residencyYears < 0)
                throw new ArgumentException("Residency years cannot be negative.");

            if (!ProfileUtilities.IsValidEmail(email))
                throw new InvalidEmailException("Invalid email format.");

            name = ProfileUtilities.FormatName(name);

            Citizen citizen = new Citizen(name, age, income, residencyYears, email, address);
            citizen.CalculateEligibility();
            citizen.AssignServicePackage();

            return citizen;
        }
    }
}
