using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class LargestAndSecondLargestElement
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int Size = 10;
            int[] Array = new int[Size];

            int Idx = 0;

            while (Number > 0)
            {
                int LastValue = Number % 10;
                Array[Idx++] = LastValue;
                Number = Number / 10;
                if (Idx == Size)
                {
                    break;
                }
            }

            int LargestElement = 0;
            int SecondLargestElement = 0;

            for (int i = 0; i < Size; i++)
            {
                if (Array[i] > LargestElement)
                {
                    SecondLargestElement = LargestElement;
                    LargestElement = Array[i];
                }
                else if (Array[i] > SecondLargestElement && Array[i] != LargestElement)
                {
                    SecondLargestElement = Array[i];
                }
            }

            Console.WriteLine($"Largest Element {LargestElement}");
            Console.WriteLine($"Second Largest Element {SecondLargestElement}");

        }
    }
}
