using System;
using System.Collections.Generic;
using HealthCare.Interfaces;
using HealthCare.Models;
using HealthCare.Exceptions;

namespace HealthCare.Service
{
    public class PrescriptionService
    {
        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IVisitRepository _visitRepository;

        public PrescriptionService(
            IPrescriptionRepository prescriptionRepository,
            IVisitRepository visitRepository)
        {
            _prescriptionRepository = prescriptionRepository;
            _visitRepository = visitRepository;
        }

        public int AddPrescription(int visitId,
                                   string medication,
                                   string dosage,
                                   string frequency,
                                   string duration)
        {
            var visit = _visitRepository.GetVisitById(visitId);

            if (visit.Status != "COMPLETED")
                throw new ValidationException(
                    "Prescription can only be added after visit completion.");

            var prescription = new Prescription(
                visitId, medication, dosage, frequency, duration);

            return _prescriptionRepository.AddPrescription(prescription);
        }

        public List<Prescription> GetPrescriptionsByVisit(int visitId)
        {
            return _prescriptionRepository.GetPrescriptionsByVisit(visitId);
        }
    }
}
