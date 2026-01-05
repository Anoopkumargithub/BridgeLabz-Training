using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.hospital_patient_management_system
{
    internal class Bills : IPayable
    {
        private InPatient patient;
        private Doctors doctor;

        private const double RoomChargePerDay = 1500;

        public Bills(InPatient patient, Doctors doctor)
        {
            this.patient = patient;
            this.doctor = doctor;
        }

        public double CalculateBill()
        {
            double roomCharges = RoomChargePerDay * patient.NumberOfDays;
            double doctorFee = doctor.getDoctorFee;

            return roomCharges + doctorFee;
        }


    }

    interface IPayable
    {
        double CalculateBill();

        

    }
}
