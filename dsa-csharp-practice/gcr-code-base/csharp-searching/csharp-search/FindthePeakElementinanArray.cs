using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.csharp_linear_search
{
    internal class FindthePeakElementinanArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find the Peak Element in an Array");
            Console.WriteLine();

            // Test cases
            int[] arr = { 1, 3, 20, 4, 1, 0 };

            Console.WriteLine("Array " + string.Join(", ", arr));
            int idx = FindPeakElement(arr);
            Console.WriteLine($"Peak element is at index {idx}, value = {arr[idx]}");
            Console.WriteLine();
        }

        public static int FindPeakElement(int[] arr)
        {
            int n = arr.Length;

            // Edge cases
            if (n == 1)
            {
                return 0;
            }

            // Check first element
            if (arr[0] > arr[1])
            {
                return 0;
            }

            // Check last element
            if (arr[n - 1] > arr[n - 2])
            {
                return n - 1;
            }

            // Binary search for peak element
            int left = 1;
            int right = n - 2;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid is peak
                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                {
                    return mid;
                }

                // If left neighbor is greater, peak is in left half
                if (arr[mid] < arr[mid - 1])
                {
                    right = mid - 1;
                }
                // Otherwise, peak is in right half
                else
                {
                    left = mid + 1;
                }
            }

            return 0;
        }
    }
}
