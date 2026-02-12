using System;

namespace HealthCare.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
    
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
    
        public string Status { get; set; }
    
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    
        // Optional display fields (JOIN purpose)
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
    
        public Appointment() { }
    
        public Appointment(int patientId, int doctorId,
                           DateTime date, TimeSpan time)
        {
            PatientID = patientId;
            DoctorID = doctorId;
            AppointmentDate = date;
            AppointmentTime = time;
            Status = "SCHEDULED";
        }
    }
    
}
