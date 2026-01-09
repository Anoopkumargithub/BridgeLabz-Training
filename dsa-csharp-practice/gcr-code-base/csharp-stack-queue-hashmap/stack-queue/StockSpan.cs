using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_stack_queue_hashmap.stack_queue
{
    internal class StockSpan
    {
        static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int n = prices.Length;

            int[] span = CalculateSpan(prices, n);

            Console.WriteLine("Stock Prices:");
            PrintArray(prices);

            Console.WriteLine("Stock Span:");
            PrintArray(span);
        }

        static int[] CalculateSpan(int[] prices, int n)
        {
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();

            // First day span is always 1
            stack.Push(0);
            span[0] = 1;

            for (int i = 1; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
                stack.Push(i);
            }

            return span;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
