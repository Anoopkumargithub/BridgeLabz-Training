using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.methods.level1
{
    internal class SumOfNaturalNumber
    {

        static void Sum(int number)
        {
            bool Natural = (number > 0) ? true : false;

            int Sum = 0;

            for (int i = 0; i < number; i++)
            {
                Sum += i;
            }

            int CalculatedSum = number * (number + 1) / 2;

            if (CalculatedSum == Sum)
            {
                Console.WriteLine($"The Sum of {number} Natural Number is {number * (number + 1) / 2} and CalculatedSum and WhileLoop Sum are same ");
            }
            else if (CalculatedSum != Sum)
            {
                Console.WriteLine($"The Sum of {number} Natural Number is {number * (number + 1) / 2} and CalculatedSum {CalculatedSum}  and WhileLoop Sum {Sum} are not same ");
            }
            else
            {
                Console.WriteLine($"The number {number} is not a natural number");
            }
        }
        static void Main()
        {

            int number = Convert.ToInt32(Console.ReadLine());
            Sum(number);
            
        }
    }
}
