using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_constructors
{
    internal class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double totalCost;

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            CalculateTotalCost();
        }

        public void CalculateTotalCost()
        {
            double rentPerDay = 0;

            if (carModel == "Swift")
            {
                rentPerDay = 1500;
            }
            else if (carModel == "Creta")
            {
                rentPerDay = 2500;
            }
            else
            {
                Console.WriteLine("Invalid Car Model");
            }

            this.totalCost = rentPerDay * rentalDays;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("----- Car Rental Bill -----");
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Car Model     : " + carModel);
            Console.WriteLine("Rental Days   : " + rentalDays);
            Console.WriteLine("Total Cost    : INR " + totalCost);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Select Car Model:");
            Console.WriteLine("1. Swift");
            Console.WriteLine("2. Creta");
            int choice = int.Parse(Console.ReadLine());

            string model = "";
            switch (choice)
            {
                case 1:
                    model = "Swift";
                    break;
                case 2:
                    model = "Creta";
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            Console.Write("Enter Rental Days: ");
            int days = int.Parse(Console.ReadLine());

            CarRental rental = new CarRental(name, model, days);
        }
    }
}

