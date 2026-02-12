using System;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Exceptions;


namespace HealthCare.Service
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepo;
        private readonly IPatientRepository _patientRepo;
        private readonly IDoctorRepository _doctorRepo;

        public AppointmentService(
            IAppointmentRepository appointmentRepo,
            IPatientRepository patientRepo,
            IDoctorRepository doctorRepo)
        {
            _appointmentRepo = appointmentRepo;
            _patientRepo = patientRepo;
            _doctorRepo = doctorRepo;
        }

        public void CreateAppointment(
            int patientId,
            int doctorId,
            DateTime date,
            TimeSpan time)
        {
            // Validate Patient
            var patient = _patientRepo.GetPatientById(patientId);
            if (patient == null)
                throw new ValidationException("Patient not found.");

            // Validate Doctor
            var doctor = _doctorRepo.GetDoctorById(doctorId);
            if (doctor == null || !doctor.IsActive)
                throw new ValidationException("Doctor not available.");

            // Business Rule: No past booking
            if (date.Date < DateTime.Today)
                throw new ValidationException("Cannot book appointment in past.");

            // Optional: working hours check
            if (time < new TimeSpan(9, 0, 0) ||
                time > new TimeSpan(18, 0, 0))
                throw new ValidationException("Outside working hours.");

            Appointment appointment =
                new Appointment(patientId, doctorId, date, time);

            _appointmentRepo.CreateAppointment(appointment);
        }

        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _appointmentRepo.GetAppointmentsByPatient(patientId);
        }

        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return _appointmentRepo.GetAppointmentsByDoctor(doctorId);
        }

        public void CancelAppointment(int appointmentId)
        {
            _appointmentRepo.CancelAppointment(appointmentId);
        }
    }

}