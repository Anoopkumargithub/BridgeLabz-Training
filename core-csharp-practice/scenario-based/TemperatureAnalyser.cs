using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class TemperatureAnalyser
    {
        static void ReadTemperatures(float[,] temps)
        {
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"Enter temperatures for Day {day + 1}:");
                for (int hour = 0; hour < 24; hour++)
                {
                    temps[day, hour] = Convert.ToSingle(Console.ReadLine());
                }
            }
        }

        static float CalculateDailyAverage(float[,] temps, int day)
        {
            float sum = 0;
            for (int hour = 0; hour < 24; hour++)
            {
                sum += temps[day, hour];
            }
            return sum / 24;
        }

        static void FindHottestAndColdestDay(float[,] temps)
        {
            float hottestAvg = CalculateDailyAverage(temps, 0);
            float coldestAvg = hottestAvg;
            int hottestDay = 1, coldestDay = 1;

            for (int day = 1; day < 7; day++)
            {
                float avg = CalculateDailyAverage(temps, day);

                if (avg > hottestAvg)
                {
                    hottestAvg = avg;
                    hottestDay = day + 1;
                }

                if (avg < coldestAvg)
                {
                    coldestAvg = avg;
                    coldestDay = day + 1;
                }
            }

            Console.WriteLine($"Hottest Day : Day {hottestDay}");
            Console.WriteLine($"Coldest Day : Day {coldestDay}");
        }

        static void Main(string[] args)
        {
            float[,] temperatures = new float[7, 24];

            ReadTemperatures(temperatures);

            Console.WriteLine("Average Temperature Per Day:");
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"Day {day + 1}: {CalculateDailyAverage(temperatures, day):F2}");
            }

            FindHottestAndColdestDay(temperatures);
        }
    }
}
