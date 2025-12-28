using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class IndexOutOfRangeExceptionExample
    {
        static void DemonstrateIndexOutOfRangeException(int[] numbers)
        {
            try
            {
                int number = numbers[6];
                Console.WriteLine($"Number at 6th index:   {number}");
            }
            catch (Exception e)
            {
                Console.WriteLine("IndexOutOfRangeException");
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            DemonstrateIndexOutOfRangeException(numbers);

        }
    }
}
