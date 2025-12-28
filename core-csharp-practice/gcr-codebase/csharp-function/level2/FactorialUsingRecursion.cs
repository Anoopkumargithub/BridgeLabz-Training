using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class FactorialUsingRecursion
    {
        static int ReadNumber()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static long Factorial(int n)
        {
            if (n < 0)
                return 0; 

            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        static void DisplayResult(int n, long result)
        {
            Console.WriteLine($"Factorial of {n} is: {result}");
        }

        static void Main(string[] args)
        {
            int number = ReadNumber();
            long result = Factorial(number);
            DisplayResult(number, result);
        }
    }
}
