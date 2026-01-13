using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.csharp_linear_search
{
    internal class FindtheRotationPointinaRotatedSortedArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find the Rotation Point in a Rotated Sorted Array");
            Console.WriteLine();

            // Test cases with rotated sorted arrays
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };

            Console.WriteLine("Array 1: " + string.Join(", ", arr));
            int idx = FindRotationPoint(arr);
            Console.WriteLine($"Rotation point (smallest element) is at index {idx}, value = {arr[idx]}");
            Console.WriteLine();
        }

        public static int FindRotationPoint(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            // If array is not rotated
            if (arr[left] < arr[right])
            {
                return 0;
            }

            // Binary search to find rotation point
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid+1 is the rotation point
                if (mid < arr.Length - 1 && arr[mid] > arr[mid + 1])
                {
                    return mid + 1;
                }

                // Check if mid is the rotation point
                if (mid > 0 && arr[mid] < arr[mid - 1])
                {
                    return mid;
                }

                // Decide which half to search
                if (arr[mid] > arr[right])
                {
                    // Rotation point is in right half
                    left = mid + 1;
                }
                else
                {
                    // Rotation point is in left half
                    right = mid;
                }
            }

            return left;
        }
    }
}
