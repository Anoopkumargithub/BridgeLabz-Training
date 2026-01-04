using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class Patient
    {
        // Static Variables
        public static string HospitalName;
        private static int totalPatients = 0;

        // Instance Variables
        public string Name;
        public readonly int PatientID;
        public int Age;
        public string Ailment;

        public Patient(string Name, int PatientID, int Age, string Ailment)
        {
            // using this keyword
            this.Name = Name;
            this.PatientID = PatientID;
            this.Age = Age;
            this.Ailment = Ailment;

            totalPatients++;
        }

        public void DisplayPatientDetails()
        {
            Console.WriteLine("Hospital Name : " + HospitalName);
            Console.WriteLine("Patient Name  : " + Name);
            Console.WriteLine("Patient ID    : " + PatientID);
            Console.WriteLine("Age           : " + Age);
            Console.WriteLine("Ailment       : " + Ailment);
        }

        // Static Method
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients Admitted : " + totalPatients);
        }
    }

    class HospitalManagement
    {
        public static void Main(string[] args)
        {
            Patient.HospitalName = "CMS Hospital";

            Patient p1 = new Patient("Bhide", 1001, 25, "Fever");
            Patient p2 = new Patient("Popat lal", 1002, 30, "Fracture");

            Console.WriteLine("Patient 1 Details:");
            if (p1 is Patient)
            {
                p1.DisplayPatientDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Patient 2 Details:");
            if (p2 is Patient)
            {
                p2.DisplayPatientDetails();
            }
            Console.WriteLine();

            Patient.GetTotalPatients();
        }
    }
}
