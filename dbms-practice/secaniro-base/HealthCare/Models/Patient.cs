using System;

namespace HealthCare.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

        public Patient(int patientId, string name, string email, string gender,DateTime dob, string bloodGroup, string contact, string address, bool isActive)
        {
            PatientId = patientId;
            Name = name;
            Email = email;
            Gender = gender;
            DateOfBirth = dob;
            BloodGroup = bloodGroup;
            Contact = contact;
            Address = address;
            IsActive = isActive;
        }

        public Patient(string name, string email, string gender, DateTime dob, string bloodGroup, string contact, string address)
        {
            Name = name;
            Email = email;
            Gender = gender;
            DateOfBirth = dob;
            BloodGroup = bloodGroup;
            Contact = contact;
            Address = address;
            IsActive = true;
        }

        public Patient()
        {
        }

        public override string ToString()
        {
            return $"ID: {PatientId}, Name: {Name}, Contact: {Contact}, Email: {Email}";
        }
    }
}
