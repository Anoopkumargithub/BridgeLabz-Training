using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class GcdLcmCalculator
    {
        static int ReadNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        static int CalculateLCM(int a, int b)
        {
            return (a * b) / CalculateGCD(a, b);
        }

        static void Main(string[] args)
        {
            int num1 = ReadNumber("Enter first number: ");
            int num2 = ReadNumber("Enter second number: ");

            int gcd = CalculateGCD(num1, num2);
            int lcm = CalculateLCM(num1, num2);

            Console.WriteLine("GCD: " + gcd);
            Console.WriteLine("LCM: " + lcm);
        }

    }
}
