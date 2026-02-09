using System;
using System.Collections.Generic;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface IDoctorRepository
    {
        // add doctor 
        int AddDoctor(Doctor doctor);

        // update doctor
        bool UpdateDoctor(Doctor doctor);

        // get doctor by id
        Doctor GetDoctorById(int doctorId);
        
        // get doctors by Speciality
        List<Doctor> GetDoctorsBySpeciality(string specialityName);

        // delete doctor details (is_Active = False)
        bool DeleteDoctor(int doctorId); // soft delete
    }
}