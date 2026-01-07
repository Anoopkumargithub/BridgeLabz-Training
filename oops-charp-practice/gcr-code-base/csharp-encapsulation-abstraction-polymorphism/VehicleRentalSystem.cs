using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism
{

    // Interface
    internal interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    // Abstract Class
    internal abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        protected double rentalRate;

        // Encapsulation via properties
        public string VehicleNumber
        {
            get { return vehicleNumber; }
        }

        public string Type
        {
            get { return type; }
        }

        protected Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.rentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails(int days)
        {
            Console.WriteLine("Vehicle Number: " + vehicleNumber);
            Console.WriteLine("Vehicle Type: " + type);
            Console.WriteLine("Rental Cost (" + days + " days): INR " + CalculateRentalCost(days));

            if (this is IInsurable)
            {
                Console.WriteLine(((IInsurable)this).GetInsuranceDetails());
                Console.WriteLine("Insurance Cost: INR " + ((IInsurable)this).CalculateInsurance());
            }

            Console.WriteLine("---------------------------");
        }
    }

    // Car
    internal class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(string number, double rate, string policyNumber)
            : base(number, "Car", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return rentalRate * 0.15;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance Policy: " + insurancePolicyNumber;
        }
    }

    // Bike
    internal class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Bike(string number, double rate, string policyNumber)
            : base(number, "Bike", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days * 0.9;
        }

        public double CalculateInsurance()
        {
            return rentalRate * 0.08;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance Policy: " + insurancePolicyNumber;
        }
    }

    // Truck
    internal class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Truck(string number, double rate, string policyNumber)
            : base(number, "Truck", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days * 1.2;
        }

        public double CalculateInsurance()
        {
            return rentalRate * 0.25;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance Policy: " + insurancePolicyNumber;
        }
    }

    // Utility Class (ARRAY + POLYMORPHISM)
    internal class VehicleUtility
    {
        private Vehicle[] vehicles;
        private int count;

        public VehicleUtility(int size)
        {
            vehicles = new Vehicle[size];
            count = 0;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (count < vehicles.Length)
            {
                vehicles[count++] = vehicle;
            }
        }

        public void DisplayRentalSummary(int days)
        {
            for (int i = 0; i < count; i++)
            {
                vehicles[i].DisplayDetails(days);
            }
        }
    }

    // Main Class
    internal class VehicleRentalSystem
    {
        static void Main(string[] args)
        {
            VehicleUtility utility = new VehicleUtility(5);

            Vehicle v1 = new Car("UP12AB1234", 2000, "CAR-INS-101");
            Vehicle v2 = new Bike("UP14XY5678", 800, "BIKE-INS-202");
            Vehicle v3 = new Truck("UP10TR9999", 5000, "TRUCK-INS-303");

            utility.AddVehicle(v1);
            utility.AddVehicle(v2);
            utility.AddVehicle(v3);

            utility.DisplayRentalSummary(5);
        }

    }
}
