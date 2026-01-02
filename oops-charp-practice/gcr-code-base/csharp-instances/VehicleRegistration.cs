using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_instances
{
    internal class Vehicle
    {
        private string ownerName;
        private string vehicleType;

        // Class Variable
        public static double registrationFee;

        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // Instance Method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name      : " + ownerName);
            Console.WriteLine("Vehicle Type    : " + vehicleType);
            Console.WriteLine("Registration Fee: INR " + registrationFee);
        }

        // Class Method
        public static void UpdateRegistrationFee(double fee)
        {
            registrationFee = fee;
        }
    }

    class VehicleRegistration
    {
        public static void Main(string[] args)
        {
            Vehicle.UpdateRegistrationFee(4500.0);

            Vehicle v1 = new Vehicle("Adam", "Two Wheeler");
            Vehicle v2 = new Vehicle("Carter", "Four Wheeler");

            Console.WriteLine("Vehicle 1 Details:");
            v1.DisplayVehicleDetails();
            Console.WriteLine();

            Console.WriteLine("Vehicle 2 Details:");
            v2.DisplayVehicleDetails();
            Console.WriteLine();
        }
    }
}
