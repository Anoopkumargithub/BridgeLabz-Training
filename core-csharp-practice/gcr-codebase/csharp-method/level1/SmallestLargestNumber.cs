using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class SmallestLargestNumber
    {
        static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = (number1 < number2 && number1 < number3)
                            ? number1
                            : (number2 < number3 ? number2 : number3);

            int largest = (number1 > number2 && number1 > number3)
                            ? number1
                            : (number2 > number3 ? number2 : number3);

            return new int[] { smallest, largest };
        }
        static void Main()
        {

            Console.WriteLine("Enter First Number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int[] result = FindSmallestAndLargest(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine($"Smallest Number: {result[0]}");
            Console.WriteLine($"Largest Number: {result[1]}");
        }
    }
}
