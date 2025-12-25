using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class FacotrsAndSomeOperations
    {
        static int[] FindFactors(int number)
        {
            int Count = 0;

            for(int i = 1; i < number; i++)
            {
                if (number % i == 0) Count++;
            }

            int[] Factors = new int[Count];

            for(int i = 1; i < Count; i++)
            {
                if(number % i == 0)
                {
                    Factors[i] = i; 
                }
            }

            return Factors;
        }

        static long ProductOfFactors(int[] factor)
        {
            long Product = 1;

            for(int i = 0;i< factor.Length; i++)
            {
                Product *= factor[i];
            }
            return Product;
        }
        static double SumOfSquareOfFactors(int[] factor)
        {
            double SumOfSquare = 0;

            for(int i = 0;i< factor.Length; i++)
            {
                SumOfSquare += Math.Pow(factor[i],2);
            }
            return SumOfSquare;
        }
        static int SumOfFactors(int[] factor)
        {
            int Sum = 0;

            for(int i = 0;i< factor.Length; i++)
            {
                Sum += factor[i];
            }
            return Sum;
        }


        static void Main (string[] args)
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] factors = FindFactors(number);

            Console.WriteLine($"Sum of Factors is {SumOfFactors(factors)}");
            Console.WriteLine($"Product of Factors is {ProductOfFactors(factors)}");
            Console.WriteLine($"Sum of square of Factors is {SumOfSquareOfFactors(factors)}");


        }
    }
}
