using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_algorithm_s_runtime_analysis
{
    internal class SearchaTarget
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = random.Next(1, 101);
            }

            int target = 78;
            array[89] = target;

            // linear Search
            DateTime startTime = DateTime.Now;
            int idx = LinearSearch(array, target);
            DateTime endTime = DateTime.Now;
            Console.WriteLine($"For Linear Search: {endTime - startTime} and target found at index {idx} ");
            // binary Search
            startTime = DateTime.Now;
            idx = BinarySearch(array, target);
            endTime = DateTime.Now;
            Console.WriteLine($"For Binary Search: {endTime - startTime} and target found at index {idx}");
        }

        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }


        public static int BinarySearch(int[] array, int target)
        {
            Array.Sort(array);

            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int mid = (right + left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
