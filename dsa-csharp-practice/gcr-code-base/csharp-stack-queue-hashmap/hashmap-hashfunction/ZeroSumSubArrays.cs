using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_stack_queue_hashmap.hashmap_hashfunction
{
    internal class ZeroSumSubArrays
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4 };

            FindZeroSumSubarrays(arr);
        }

        static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            // Initialize for sum = 0 at index -1
            map[0] = new List<int> { -1 };

            Console.WriteLine("Zero Sum Subarrays:");

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine($"Subarray found from index {startIndex + 1} to {i}");
                    }
                    map[sum].Add(i);
                }
                else
                {
                    map[sum] = new List<int> { i };
                }
            }
        }
    }
}
