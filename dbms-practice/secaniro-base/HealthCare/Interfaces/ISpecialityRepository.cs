using System;
using System.Collections.Generic;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface ISpecialityRepository
    {
        // Add Speciality
        int AddSpeciality(string name);

        // List All the Speciality
        List<Speciality> GetAllSpecialities();
        
        // get any Speciality by Id
        Speciality GetById(int specialityId);

        // search any speciality by name
        List<Speciality> SearchSpeciality(string keyword);
    }
}