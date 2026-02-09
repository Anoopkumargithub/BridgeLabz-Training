using System;
using System.Collections.Generic;
using HealthCare.Models;

namespace HealthCare.Interfaces{

    public interface IPatientRepository
    {
        // register new patient -> return Id
        int AddPatient(Patient patient);

        //  update patient -> return true (for successfull  updatation) false (fro unsuccessfull)
        bool UpdatePatient(Patient patient);

        // search patient by name or contact -> return lsit of  patients 
        List<Patient> SearchPatient(string keyword);

        //  get patient  by Id
        Patient GetPatientById(int patientId);

        // delete patient 
        bool DeletePatient(int patientId);
    }
}