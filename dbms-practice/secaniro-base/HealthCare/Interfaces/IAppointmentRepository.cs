using System;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface IAppointmentRepository
    {
        // create Appointment
        void CreateAppointment(Appointment appointment);
        
        // get Appointment by Doctor 
        List<Appointment> GetAppointmentsByDoctor(int doctorId);

        // get appointment by doctor
        List<Appointment> GetAppointmentsByPatient(int patientId);

        // update appointment
        void UpdateStatus(int appointmentId, string status);

        //get Appointment By Id
        Appointment GetAppointmentById(int appointmentId);

        // cancel appointment
        void CancelAppointment(int appointmentId);
    }
}