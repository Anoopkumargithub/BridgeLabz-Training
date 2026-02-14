using System;

namespace HealthCare.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public int VisitID { get; set; }

        public string Medication { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string Duration { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // For JOIN display
        public string PatientName { get; set; }
        public string DoctorName { get; set; }

        public Prescription() { }

        public Prescription(int visitId, string medication,
                            string dosage, string frequency,
                            string duration)
        {
            VisitID = visitId;
            Medication = medication;
            Dosage = dosage;
            Frequency = frequency;
            Duration = duration;
        }
    }
}
