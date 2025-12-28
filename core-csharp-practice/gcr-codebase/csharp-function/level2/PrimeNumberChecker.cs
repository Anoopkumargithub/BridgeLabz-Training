using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class PrimeNumberChecker
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(num))
                Console.WriteLine($"{num} is a PRIME number");
            else
                Console.WriteLine($"{num} is NOT a prime number");
        }
    }
}
