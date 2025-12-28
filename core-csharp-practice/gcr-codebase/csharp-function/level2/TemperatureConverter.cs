using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class TemperatureConverter
    {
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.Write("Choose an option (1 or 2): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double f = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Celsius: {FahrenheitToCelsius(f):F2}");
            }
            else if (choice == 2)
            {
                Console.Write("Enter temperature in Celsius: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Fahrenheit: {CelsiusToFahrenheit(c):F2}");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
