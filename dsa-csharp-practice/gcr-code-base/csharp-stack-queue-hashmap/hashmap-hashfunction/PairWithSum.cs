using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_stack_queue_hashmap.stack_queue
{
    internal class PairWithSum
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 1, 6, 2 };
            int target = 10;

            bool result = HasPairWithSum(arr, target);

            Console.WriteLine(result
                ? "Pair with given sum exists."
                : "No pair with given sum found.");
        }

        static bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> visited = new HashSet<int>();

            foreach (int num in arr)
            {
                int required = target - num;

                if (visited.Contains(required))
                {
                    Console.WriteLine($"Pair Found: {num} + {required} = {target}");
                    return true;
                }

                visited.Add(num);
            }

            return false;
        }
    }
}
