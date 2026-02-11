using System;

namespace HealthCare.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int SpecialityID { get; set; }
        public string SpecialityName { get; set; }   // for join
        public string Contact { get; set; }
        public string Email { get; set; }
        public decimal ConsultationFee { get; set; }
        public bool IsActive { get; set; }

        public Doctor() { }

        public Doctor(
            int doctorId,
            string name,
            int specialityId,
            string specialityName,
            string contact,
            string email,
            decimal consultationFee,
            bool isActive)
        {
            DoctorId = doctorId;
            Name = name;
            SpecialityID = specialityId;
            SpecialityName = specialityName;
            Contact = contact;
            Email = email;
            ConsultationFee = consultationFee;
            IsActive = isActive;
        }

        public Doctor(string name, int specialityId, string contact, string email, decimal consultationFee)
        {
            Name = name;
            SpecialityID = specialityId;
            Contact = contact;
            Email = email;
            ConsultationFee = consultationFee;
            IsActive = true;
        }
    }
}
