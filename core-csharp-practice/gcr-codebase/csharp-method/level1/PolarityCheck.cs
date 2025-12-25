using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.methods.level1
{
    internal class PolarityCheck
    {
        static string Polarity(int number)
        {
            if (number > 0)
            {
                return  "Positive";
            }
            else if (number < 0)
            {
                return  "Negative";
            }
            else
            {
                return "Zero";
            }
        }
        static void Main()
        {

            Console.WriteLine("Enter a Number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number is {Polarity(number)}");
        }
    }
}
