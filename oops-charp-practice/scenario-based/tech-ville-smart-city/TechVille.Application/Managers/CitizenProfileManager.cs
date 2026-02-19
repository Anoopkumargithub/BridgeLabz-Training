using TechVille.Domain.Entities;
using TechVille.Application.Utilities;
using System.Collections.Generic;

namespace TechVille.Application.Managers
{
    /// <summary>
    /// Manages searching and updating citizen profiles.
    /// </summary>
    public class CitizenProfileManager
    {
        private List<Citizen> _citizens;

        public CitizenProfileManager(List<Citizen> citizens)
        {
            _citizens = citizens;
        }

        /// <summary>
        /// Searches citizen by name.
        /// </summary>
        public Citizen SearchByName(string name)
        {
            foreach (var citizen in _citizens)
            {
                if (ProfileUtilities.NameMatches(citizen.Name, name))
                    return citizen;
            }

            return null;
        }

        /// <summary>
        /// Updates citizen profile.
        /// </summary>
        public void UpdateCitizen(Citizen citizen, string email, string address)
        {
            citizen.UpdateProfile(email, address);
        }
    }
}
