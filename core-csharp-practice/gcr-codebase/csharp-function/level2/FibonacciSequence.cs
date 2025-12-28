using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class FibonacciSequence
    {
        static void PrintFibonacci(int terms)
        {
            if (terms <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }

            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Sequence:");

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            PrintFibonacci(terms);
        }
    }
}
