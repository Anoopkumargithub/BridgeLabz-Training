using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.csharp_linear_search
{
    internal class FindMissingPositiveAndTarget
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Find First Missing Positive Integer and Search Target ===");
            Console.WriteLine();

            // Test cases
            int[][] testArrays = {
                new int[] { 3, 4, -1, 1, 7, 8, 2 },
                new int[] { 1, 2, 0 }
            };

            for (int i = 0; i < testArrays.Length; i++)
            {
                Console.WriteLine($"--- Test Case {i + 1} ---");
                Console.WriteLine("Array: " + string.Join(", ", testArrays[i]));

                int missing = FindFirstMissingPositive(testArrays[i]);
                Console.WriteLine($"First missing positive: {missing}");
                Console.WriteLine();
            }

            //  search
            Console.WriteLine("--- Binary Search ---");
            Console.Write("Enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] userArr = new int[n];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                userArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Original Array: " + string.Join(", ", userArr));
            Console.WriteLine();

            // Find missing positive
            int userMissing = FindFirstMissingPositive(userArr);
            Console.WriteLine($"First missing positive integer: {userMissing}");
            Console.WriteLine();

            // Binary search
            Console.Write("Enter target to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] originalCopy = new int[userArr.Length];
            Array.Copy(userArr, originalCopy, userArr.Length);

            int idx = BinarySearchTarget(userArr, target);

            if (idx != -1)
            {
                Console.WriteLine($"Target {target} found at index {idx} (in sorted array)");

                // Find in original array
                int originalIdx = Array.IndexOf(originalCopy, target);
                if (originalIdx != -1)
                {
                    Console.WriteLine($"Target {target} was at index {originalIdx} (in original array)");
                }
            }
            else
            {
                Console.WriteLine($"Target {target} not found");
            }
        }

        public static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;

            // Separate approach using marking
            bool[] present = new bool[n + 2];

            // Mark all positive numbers that are <= n
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] <= n + 1)
                {
                    present[arr[i]] = true;
                }
            }

            // Find first missing positive
            for (int i = 1; i <= n + 1; i++)
            {
                if (!present[i])
                {
                    return i;
                }
            }

            return n + 1;
        }

        public static int BinarySearchTarget(int[] arr, int target)
        {
            // Sort the array
            Array.Sort(arr);

            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
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
