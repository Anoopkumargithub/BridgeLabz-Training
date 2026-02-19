using System;
using TechVille.Domain.Enums;


namespace TechVille.Domain.Entities
{
    /// <summary>
    /// Represents a citizen in TechVille Smart City.
    /// </summary>
    public class Citizen
    {
        /// <summary>
        /// Full name of citizen.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Age of citizen.
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Annual income.
        /// </summary>
        public double Income { get; private set; }

        /// <summary>
        /// Number of years living in TechVille.
        /// </summary>
        public int ResidencyYears { get; private set; }

        /// <summary>
        /// Eligibility score calculated based on business rules.
        /// </summary>
        public double EligibilityScore { get; private set; }

        public string Email { get; private set; }
        public string Address { get; private set; }


        /// <summary>
        /// Assigned service package.
        /// </summary>
        public ServicePackage Package { get; private set; }

        /// <summary>
        /// Constructor to initialize citizen.
        /// </summary>
        public Citizen(string name, int age, double income, int residencyYears, string email, string address)
        {
            Name = name;
            Age = age;
            Income = income;
            ResidencyYears = residencyYears;
            Email = email;
            Address = address;
        }

        /// <summary>
        /// Calculates eligibility score based on defined formula.
        /// </summary>
        public void CalculateEligibility()
        {
            // Simple formula (can evolve later)
            EligibilityScore = (Age * 0.3) +
                               (ResidencyYears * 2) +
                               (Income / 10000);
        }

        /// <summary>
        /// Assigns service package based on eligibility score.
        /// </summary>
        public void AssignServicePackage()
        {
           if (EligibilityScore < 20)
               Package = ServicePackage.Basic;
           else if (EligibilityScore < 40)
               Package = ServicePackage.Silver;
           else if (EligibilityScore < 60)
               Package = ServicePackage.Gold;
           else
               Package = ServicePackage.Platinum;
        }

        /// <summary>
        /// Updates citizen email and address.
        /// </summary>
        public void UpdateProfile(string email, string address)
        {
            Email = email;
            Address = address;
        }
        


        /// <summary>
        /// Returns formatted citizen information.
        /// </summary>
        public override string ToString()
        {
           return $"Name: {Name}, Age: {Age}, Income: {Income}, Residency: {ResidencyYears} years, Score: {EligibilityScore:F2}, Package: {Package}";
        }
    }
}
