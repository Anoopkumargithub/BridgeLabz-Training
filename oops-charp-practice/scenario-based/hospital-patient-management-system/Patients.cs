using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.hospital_patient_management_system
{
    internal class Patients : IPatient
    {
        private int patientId;
        private string name;

        public Patients(int patientId, string name)
        {
            this.patientId = patientId;
            this.name = name;
        }

        public int PatientId
        {
            get { return patientId; }
        }

        public string Name
        {
            get { return name; }
        }

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("Patient Id: " + patientId);
            Console.WriteLine("Patient Name: " + name);
        }

    }

    interface IPatient
    {
        void DisplayAccountInfo();
    }

    // Inheritance + polymorphism
    class InPatient : Patients
    {
        private int numberOfDays;

        public InPatient(int patientId, string patientName, int numberOfDays)
            : base(patientId, patientName)
        {
            this.numberOfDays = numberOfDays;
        }

        public int NumberOfDays
        {
            get { return numberOfDays; }
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Admitted Days: {numberOfDays}");
        }
    }

    class OutPatient : Patients
    {
        private string visitDate;

        public OutPatient(int patientId, string patientName, string visitDate)
            : base(patientId, patientName)
        {
            this.visitDate = visitDate;
        }

        public override void DisplayAccountInfo()
        {
            base.DisplayAccountInfo();
            Console.WriteLine($"Visit Date: {visitDate}");
        }
    }
}
