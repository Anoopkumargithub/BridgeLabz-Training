using System;

namespace HealthCare.Models
{
    public class Visit
    {
        public int VisitID { get; set; }
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }

        public string Diagnosis { get; set; }
        public string Notes { get; set; }

        public string Status { get; set; }

        public DateTime VisitDate { get; set; }
        public DateTime UpdatedAt { get; set; }

        // For JOIN display
        public string PatientName { get; set; }
        public string DoctorName { get; set; }

        public Visit() { }

        public Visit(int appointmentId, int patientId, int doctorId)
        {
            AppointmentID = appointmentId;
            PatientID = patientId;
            DoctorID = doctorId;
            Status = "IN_PROGRESS";
        }
    }
}
