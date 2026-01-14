using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_algorithm_s_runtime_analysis
{
    internal class RecursivevsIterativeFibonacciComputation
    {
        public static void Main(string[] args)
        {
            int n = 35;
            // Recursive Fibonacci 
            DateTime startTime = DateTime.Now;
            long recursiveResult = FibonacciRecursive(n);
            DateTime endTime = DateTime.Now;
            TimeSpan recursiveTime = endTime - startTime;
            Console.WriteLine($"Recursive: Result = {recursiveResult}");
            Console.WriteLine($"Time = {recursiveTime.TotalMilliseconds:F4} ms");
            Console.WriteLine();

            // Iterative Fibonacci 
            startTime = DateTime.Now;
            long iterativeResult = FibonacciIterative(n);
            endTime = DateTime.Now;
            TimeSpan iterativeTime = endTime - startTime;
            Console.WriteLine($"Iterative: Result = {iterativeResult}");
            Console.WriteLine($"Time = {iterativeTime.TotalMilliseconds:F4} ms");
            Console.WriteLine();
        }

        public static long FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        
        public static long FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            long prev = 0;
            long current = 1;
            long result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = prev + current;
                prev = current;
                current = result;
            }

            return result;
        }
    }
}
