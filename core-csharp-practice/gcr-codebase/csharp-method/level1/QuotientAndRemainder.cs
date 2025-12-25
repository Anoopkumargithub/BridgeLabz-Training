using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class QuotientAndRemainder
    {
        static int[] FindQuotientAndRemainder(int number1, int number2)
        {
            int Quotient = number1 / number2;
            int Remainder = number1 % number2;

            return new int[]{Remainder, Quotient};
        }
        static void Main()
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int[] Result = FindQuotientAndRemainder(firstNumber, secondNumber);


            Console.WriteLine($"The Quotient is {Result[1]} and Remainder is {Result[0]} of two numbers {firstNumber} and {secondNumber}.");
        }
    }
}
