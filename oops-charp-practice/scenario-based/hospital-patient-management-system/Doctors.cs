using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.hospital_patient_management_system
{
    internal class Doctors : IDoctor
    {
        private int doctorId;
        private string doctorName;
        private Patients[] patients;
        private int doctorFee;

        public Doctors(int doctorId, string doctorName, Patients[] patients, int doctorFee)
        {
            this.doctorId = doctorId;
            this.doctorName = doctorName;
            this.patients = patients;
            this.doctorFee = doctorFee;
        }

        public int PatientCount
        {
            get { return patients.Length; }
        }

        public int getDoctorId
        {
            get { return doctorId; }
        }

        public string getDoctorName
        {
            get { return doctorName; }
        }

        public int getDoctorFee
        {
            get { return doctorFee; }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Doctor Id: " + doctorId);
            Console.WriteLine("Doctor Name: " + doctorName);
        }

        public void PatientData()
        {
            Console.WriteLine("Patients Data:");
            Console.WriteLine();
            for (int i = 0; i < patients.Length; i++)
            {
                Console.Write($"{i}. ");
                patients[i].DisplayAccountInfo();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public Patients[] GetPatients()
        {
            return patients;
        }
    }

    interface IDoctor
    {
        void DisplayAccountInfo();
    }
}
