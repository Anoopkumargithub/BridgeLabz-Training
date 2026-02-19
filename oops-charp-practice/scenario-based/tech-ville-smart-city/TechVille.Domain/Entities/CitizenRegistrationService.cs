using TechVille.Domain.Entities;

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
        public Citizen Register(string name, int age, double income, int residencyYears)
        {
            // Basic validation using comparison operators
            if (age <= 0)
                throw new ArgumentException("Age must be greater than 0.");

            if (income < 0)
                throw new ArgumentException("Income cannot be negative.");

            if (residencyYears < 0)
                throw new ArgumentException("Residency years cannot be negative.");

            Citizen citizen = new Citizen(name, age, income, residencyYears);
            citizen.CalculateEligibility();
            citizen.AssignServicePackage();

            return citizen;
        }
    }
}
