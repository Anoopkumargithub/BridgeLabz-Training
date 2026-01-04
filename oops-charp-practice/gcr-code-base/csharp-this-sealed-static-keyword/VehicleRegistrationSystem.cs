using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class Vehicle
    {
        // Static Variable
        public static double RegistrationFee;

        // Instance Variables
        public string OwnerName;
        public readonly int RegistrationNumber;
        public string VehicleType;

        public Vehicle(string OwnerName, int RegistrationNumber, string VehicleType)
        {
            // using this keyword
            this.OwnerName = OwnerName;
            this.RegistrationNumber = RegistrationNumber;
            this.VehicleType = VehicleType;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name          : " + OwnerName);
            Console.WriteLine("Registration Number : " + RegistrationNumber);
            Console.WriteLine("Vehicle Type        : " + VehicleType);
            Console.WriteLine("Registration Fee    : INR " + RegistrationFee);
        }

        // Static Method
        public static void UpdateRegistrationFee(double fee)
        {
            RegistrationFee = fee;
        }
    }

    class VehicleRegistrationSystem
    {
        public static void Main(string[] args)
        {
            Vehicle.UpdateRegistrationFee(5000);

            Vehicle v1 = new Vehicle("Bhide", 12345, "Two Wheeler");
            Vehicle v2 = new Vehicle("Roshan", 12346, "Four Wheeler");

            Console.WriteLine("Vehicle 1 Details:");
            if (v1 is Vehicle)
            {
                v1.DisplayVehicleDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Vehicle 2 Details:");
            if (v2 is Vehicle)
            {
                v2.DisplayVehicleDetails();
            }
        }
    }
}
