using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class SumOfNautralNumber
    {
        static int FindSumByRecursion(int number, int sum)
        {
            if(number == 0) return sum;

            return FindSumByRecursion(number - 1, sum + number);
            
        }
        static int FindSumByFormulae(int number)
        {
            int sum = number * (number + 1) / 2;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("Enter a Natural Number Only!!");
            }
            else
            {
               int RecursiveSum =  FindSumByRecursion(number,0);
               int FormulaeSum =  FindSumByFormulae(number);

                if (RecursiveSum == FormulaeSum)
                {
                    Console.WriteLine("Both sum are equal");
                }
                else 
                {
                    Console.WriteLine("Sum are different");
                }
            }
        }
    }
}
