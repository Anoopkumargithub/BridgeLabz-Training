using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConverter
    {
        static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }

        static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }

        static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }

        static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Convert 10Km To Miles {ConvertKmToMiles(10)}");
            Console.WriteLine($"Convert 10 Miles To Km {ConvertMilesToKm(10)}");
            Console.WriteLine($"Convert 10 Meter To Feet {ConvertMetersToFeet(10)}");
            Console.WriteLine($"Convert 10 Feet To Meter {ConvertFeetToMeters(10)}");
        }
    }
}
