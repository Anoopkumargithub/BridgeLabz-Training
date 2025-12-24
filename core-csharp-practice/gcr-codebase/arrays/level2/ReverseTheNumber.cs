using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class ReverseTheNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            // Temp Variable

            int Temp = Number;
            int NumberLength = 0;
            while (Temp > 0)
            {
                int A = Temp % 10;
                NumberLength++;
                Temp /= 10;
            }

            int[] Array = new int[NumberLength];
            int idx = 0;
            while (Number > 0)
            {
                Array[idx++] = Number % 10;
                Number /= 10;
            }

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }

        }
    }
}
