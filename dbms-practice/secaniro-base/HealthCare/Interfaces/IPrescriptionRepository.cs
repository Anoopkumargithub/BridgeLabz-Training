using System;
using System.Collections.Generic;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface IPrescriptionRepository
    {
        int AddPrescription(Prescription prescription);

        List<Prescription> GetPrescriptionsByVisit(int visitId);
    }
}
