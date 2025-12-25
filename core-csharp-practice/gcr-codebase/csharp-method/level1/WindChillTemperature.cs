using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class WindChillTemperature
    {
        static double CalculateWindChill(double temperature, double windSpeed)
        {
            double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * windSpeed * 0.16;

            return windChill;

        }
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter Wind Speed: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Wind Chill is {CalculateWindChill(temperature, windSpeed)}");

        }
    }
}
