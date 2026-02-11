using System;

namespace HealthCare.Models
{
    public class Speciality
    {
        public int SpecialityID { get; set; }
        public string SpecialityName { get; set; }
        // public bool IsActive { get; set; } // future use

        public Speciality() { }

        public Speciality(int specialityID, string specialityName)
        {
            SpecialityID = specialityID;
            SpecialityName = specialityName;
        }


    }
}