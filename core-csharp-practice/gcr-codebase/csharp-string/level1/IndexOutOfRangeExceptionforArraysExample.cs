using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class IndexOutOfRangeExceptionforArraysExample
    {
        static void DemonstrateIndexOutOfRangeExceptionforArrays(int[] numbers)
        {
            try
            {
                int number = numbers[6];
                Console.WriteLine($"Number at 6th index:   {number}");
            }
            catch (Exception e)
            {
                Console.WriteLine("IndexOutOfRangeExceptionforArrays");
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            DemonstrateIndexOutOfRangeExceptionforArrays(numbers);

        }
    }
}
