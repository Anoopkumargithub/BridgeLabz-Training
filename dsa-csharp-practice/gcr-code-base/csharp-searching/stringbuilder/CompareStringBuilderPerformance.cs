using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class CompareStringBuilderPerformance
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Compare StringBuilder Performance");
            Console.WriteLine();
            string str = "Hello";
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                str += "Hi";
            }
            DateTime endTime = DateTime.Now;

            Console.WriteLine($"Total time for string Operation: {endTime - startTime} ");

            Console.WriteLine();

            StringBuilder sb = new StringBuilder("hello");
            startTime = DateTime.Now;

            for (int i = 0; i < 1000; i++)
            {
                sb.Append("Hi");
            }
            endTime = DateTime.Now;

            Console.WriteLine($" Total time for String Builder Operation: {endTime - startTime}");
        }
    }
}
