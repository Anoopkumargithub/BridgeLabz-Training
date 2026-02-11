using System;

namespace HealthCare.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        public int PatientID { get; set; }
        public string PatientName { get; set; }   // From JOIN

        public int DoctorID { get; set; }
        public string DoctorName { get; set; }    // From JOIN

        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }

        public string Status { get; set; }

        public Appointment() { }

        public Appointment(
            int appointmentId,
            int patientId,
            string patientName,
            int doctorId,
            string doctorName,
            DateTime date,
            TimeSpan time,
            string status)
        {
            AppointmentID = appointmentId;
            PatientID = patientId;
            PatientName = patientName;
            DoctorID = doctorId;
            DoctorName = doctorName;
            AppointmentDate = date;
            AppointmentTime = time;
            Status = status;
        }
    }
}
