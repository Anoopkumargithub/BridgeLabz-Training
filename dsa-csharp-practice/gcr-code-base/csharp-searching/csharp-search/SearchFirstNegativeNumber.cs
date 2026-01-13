using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.csharp_linear_search
{
    internal class SearchFirstNegativeNumber
    {
        public static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 34, 24, -1, 43, 09 };
            int idx = FirstNegativeNumber(Numbers);
            if (idx == -1)
            {
                Console.WriteLine("No Negativ e Number Present");
            }
            else
            {
                Console.WriteLine($"First Negative number is present on index {idx} and Number is {Numbers[idx]}");
            }
        }

        static int FirstNegativeNumber(int[] Numbers)
        {
            // Linear Search
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
