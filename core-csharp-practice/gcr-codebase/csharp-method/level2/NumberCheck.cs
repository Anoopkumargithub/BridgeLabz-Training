using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class NumberCheck
    {
        static bool IsPositive(int number)
        {
            return number >= 0;
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static int Compare(int number1, int number2)
        {
            if (number1 > number2)
                return 1;
            else if (number1 == number2)
                return 0;
            else
                return -1;
        }

        static void Main()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPositive(numbers[i]))
                {
                    if (IsEven(numbers[i]))
                    {
                        Console.WriteLine($"{numbers[i]} is Positive and Even");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} is Positive and Odd");
                    }
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is Negative");
                }
            }
            int result = Compare(numbers[0], numbers[numbers.Length - 1]);

            if (result == 1)
            {
                Console.WriteLine("First element > Last element");
            }
            else if (result == 0)
            {
                Console.WriteLine("First element = Last element");
            }
            else
            {
                Console.WriteLine("First element < Last element");
            }
        }
    }
}
