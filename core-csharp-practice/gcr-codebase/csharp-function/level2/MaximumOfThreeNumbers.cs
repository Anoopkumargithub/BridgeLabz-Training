using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class MaximumOfThreeNumbers
    {
        static int ReadInteger(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int FindMaximum(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }

        static void Main(string[] args)
        {
            int num1 = ReadInteger("Enter first number: ");
            int num2 = ReadInteger("Enter second number: ");
            int num3 = ReadInteger("Enter third number: ");

            int max = FindMaximum(num1, num2, num3);

            Console.WriteLine("\nMaximum number is: " + max);
        }
    }
}
