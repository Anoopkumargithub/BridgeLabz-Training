using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class PolarityOfNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers: ");

            int[] Numbers = new int[5];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());

                CheckPolarity(Numbers[i]);
            }
        }

        private static void CheckPolarity(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is Negative");
            }
            else
            {
                Console.WriteLine($"{number} is Zero");
            }
        }
    }
}
