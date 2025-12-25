using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level3
{
    internal class FootBallTeam
    {
        static double HeightSum(double[] heights)
        {
            double sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            return sum;
        }
        static double HeightMean(double sum, int length)
        {
            return sum / length;
        }
        
        static double ShortestHeight(double[] heights)
        {
            double shortest = heights[0];

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < shortest)
                {
                    shortest = heights[i];
                }
            }
            return shortest;
        }

        static double TallestHeight(double[] heights)
        {
            double tallest = heights[0];

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > tallest)
                {
                    tallest = heights[i];
                }
            }
            return tallest;
        }
        static void Main()
        {

            double[] heights = new double[11];

            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine("Enter a Height:");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }
                double sumOfHeigths = HeightSum(heights);
                double MeanOfHeight = HeightMean(sumOfHeigths, heights.Length);
                double ShortestOfHeight = ShortestHeight(heights);
                double TallestOfHeight = TallestHeight(heights);


            Console.WriteLine($"Sum of Heights: {sumOfHeigths}");
            Console.WriteLine($"Mean Height: {MeanOfHeight}");
            Console.WriteLine($"Shortest Height: {ShortestOfHeight}");
            Console.WriteLine($"Tallest Height: {TallestOfHeight}");

        }
    }
}
