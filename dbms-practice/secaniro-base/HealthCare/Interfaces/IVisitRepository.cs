using System.Collections.Generic;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface IVisitRepository
    {
        // create visit
        int CreateVisit(Visit visit);

        // Get the visit details by id
        Visit GetVisitById(int visitId);

        // list all the visits by the doctor id
        List<Visit> GetVisitsByDoctor(int doctorId);

        //  list all the visits by the patient id
        List<Visit> GetVisitsByPatient(int patientId);

        // Call when visit is completed then it marks the visit COMPLETED
        void CompleteVisit(int visitId, string diagnosis, string notes);
    }
}
