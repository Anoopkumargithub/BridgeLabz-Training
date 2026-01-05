using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.vehicle_rent_system
{
    internal class Vehicle
    {
        protected int vehicleId;
        protected string brand;
        protected double ratePerDay;

        public Vehicle(int vehicleId, string brand, double ratePerDay)
        {
            this.vehicleId = vehicleId;
            this.brand = brand;
            this.ratePerDay = ratePerDay;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Rate/Day: {ratePerDay}");
        }
    }

    // Bike Class
    class Bike : Vehicle, IRentable
    {
        public Bike(int vehicleId, string brand, double ratePerDay)
            : base(vehicleId, brand, ratePerDay)
        {
        }

        public double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }


    // Car class 
    class Car : Vehicle, IRentable
    {
        public Car(int vehicleId, string brand, double ratePerDay)
            : base(vehicleId, brand, ratePerDay)
        {
        }

        public double CalculateRent(int days)
        {
            return (ratePerDay * days) + 500; // car service charge
        }
    }

    // Truck Class 
    class Truck : Vehicle, IRentable
    {
        public Truck(int vehicleId, string brand, double ratePerDay)
            : base(vehicleId, brand, ratePerDay)
        {
        }

        public double CalculateRent(int days)
        {
            return (ratePerDay * days) + (days * 1000); // heavy load charge
        }
    }


    // Interface 
    interface IRentable
    {
        double CalculateRent(int days);
    }


    // Customer class
    class Customer
    {
        private int customerId;
        private string customerName;

        public Customer(int customerId, string customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
        }
    }

    class Program
    {
        static void Main()
        {
            Customer customer = new Customer(1, "Anoop");

            IRentable bike = new Bike(101, "Hero", 300);
            IRentable car = new Car(102, "Honda", 1200);
            IRentable truck = new Truck(103, "Tata", 2500);

            customer.DisplayCustomer();
            Console.WriteLine();

            Console.WriteLine("Bike Rent (3 days): " + bike.CalculateRent(3));
            Console.WriteLine("Car Rent (3 days): " + car.CalculateRent(3));
            Console.WriteLine("Truck Rent (3 days): " + truck.CalculateRent(3));
        }
    }


}
