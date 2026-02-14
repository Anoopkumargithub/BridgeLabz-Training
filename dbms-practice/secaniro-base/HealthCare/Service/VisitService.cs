using System;
using System.Collections.Generic;
using HealthCare.Interfaces;
using HealthCare.Models;
using HealthCare.Exceptions;

namespace HealthCare.Service
{
    public class VisitService
    {
        private readonly IVisitRepository _visitRepository;
        private readonly IAppointmentRepository _appointmentRepository;

        public VisitService(
            IVisitRepository visitRepository,
            IAppointmentRepository appointmentRepository)
        {
            _visitRepository = visitRepository;
            _appointmentRepository = appointmentRepository;
        }

        // Receptionist creates visit
        public int StartVisit(int appointmentId)
        {
            var appointment = _appointmentRepository.GetAppointmentById(appointmentId);

            if (appointment.Status != "SCHEDULED")
                throw new ValidationException("Visit can only start for scheduled appointments.");

            var visit = new Visit(
                appointmentId,
                appointment.PatientID,
                appointment.DoctorID
            );

            return _visitRepository.CreateVisit(visit);
        }

        // Doctor completes visit
        public void CompleteVisit(int visitId, string diagnosis, string notes)
        {
            var visit = _visitRepository.GetVisitById(visitId);

            if (visit.Status == "COMPLETED")
                throw new ValidationException("Visit already completed.");

            _visitRepository.CompleteVisit(visitId, diagnosis, notes);

            // Update appointment status
            _appointmentRepository.UpdateStatus(visit.AppointmentID, "COMPLETED");
        }

        public List<Visit> GetVisitsByDoctor(int doctorId)
        {
            return _visitRepository.GetVisitsByDoctor(doctorId);
        }

        public List<Visit> GetVisitsByPatient(int patientId)
        {
            return _visitRepository.GetVisitsByPatient(patientId);
        }
    }
}
