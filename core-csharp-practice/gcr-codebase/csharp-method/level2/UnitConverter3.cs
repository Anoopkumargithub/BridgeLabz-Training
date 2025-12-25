using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConverter3
    {
        static double ConvertFarhenheitToCelsius(double farhenheit) 
        { 
            return (farhenheit - 32) * 5 / 9;
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double ConvertPoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }

        static double ConvertKilogramsToPounds(double kg)
        {
            double kilograms2pounds = 2.20462;
            return kg * kilograms2pounds;
        }
        
        static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }
        
        static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Convert 10 degree Farhenheit to Celsius {ConvertFarhenheitToCelsius(10)}");
            Console.WriteLine($"Convert 10 degree Celsius to Fahrenheit {ConvertCelsiusToFahrenheit(10)}");
            Console.WriteLine($"Convert 10 Pounds to Kilograms {ConvertPoundsToKilograms(10)}");
            Console.WriteLine($"Convert 10 Kilograms to Pounds {ConvertKilogramsToPounds(10)}");
            Console.WriteLine($"Convert 10 Gallons to Liters {ConvertGallonsToLiters(10)}");
            Console.WriteLine($"Convert 10 Liters to Gallons {ConvertLitersToGallons(10)}");
        }
    }
}
