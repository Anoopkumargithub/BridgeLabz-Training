using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConverter2
    {
        static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        static double ConvertFeetToYard(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        static double ConvertInchesToCentiMeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Convert 10Yards To Feet {ConvertYardsToFeet(10)}");
            Console.WriteLine($"Convert 10 Feet To Yards {ConvertFeetToYard(10)}");
            Console.WriteLine($"Convert 10 Meter To Inches {ConvertMetersToInches(10)}");
            Console.WriteLine($"Convert 10 Inches To Meter {ConvertInchesToMeters(10)}");
            Console.WriteLine($"Convert 10 Inches To CentiMeter {ConvertInchesToCentiMeters(10)}");
        }
    }
}
