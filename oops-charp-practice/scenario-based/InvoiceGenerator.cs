using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class InvoiceGenerator
    {
        static int Menu()
        {
            Console.WriteLine("_______Invoice Generator_______");
            Console.WriteLine("1. Generate Invoice");
            Console.WriteLine("2. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        InvoiceOperations.ParseInvoice();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Thank You");
                        return 1;
                    }
            }
            return Menu();
        }

        public static void Main(string[] args)
        {
            Menu();
        }
    }

    internal class InvoiceOperations
    {
        internal static void ParseInvoice()
        {
            Console.WriteLine("____Invoice Input____");
            Console.WriteLine("Enter invoice details:");
            string input = Console.ReadLine();

            // Split tasks by comma
            string[] tasks = input.Split(',');

            int totalAmount = GetTotalAmount(tasks);

            Console.WriteLine("____Invoice Summary____");
            foreach (string task in tasks)
            {
                Console.WriteLine(task.Trim());
            }

            Console.WriteLine($"Total Invoice Amount: {totalAmount} INR");
        }

        internal static int GetTotalAmount(string[] tasks)
        {
            int total = 0;

            foreach (string task in tasks)
            {
                // Example: "Logo Design - 3000 INR"
                string[] parts = task.Split('-');

                string amountPart = parts[1].Trim();   // "3000 INR"
                string[] amountArray = amountPart.Split(' ');

                int amount = Convert.ToInt32(amountArray[0]);
                total += amount;
            }

            return total;
        }
    }
}
