using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_algorithm_s_runtime_analysis
{
    internal class Sorting
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(1, 101);
            }

            // Create copies for each sorting algorithm to get accurate time measurements
            int[] bubbleArray = (int[])array.Clone();
            int[] mergeArray = (int[])array.Clone();
            int[] quickArray = (int[])array.Clone();

            // Bubble sort
            DateTime startTime = DateTime.Now;
            BubbleSort(bubbleArray);
            DateTime endTime = DateTime.Now;
            Console.WriteLine($"For Bubble Sort: {endTime - startTime}");


            // Merge Sort
            startTime = DateTime.Now;
            MergeSort(mergeArray, 0, mergeArray.Length - 1);
            endTime = DateTime.Now;
            Console.WriteLine($"For Merge Sort: {endTime - startTime}");


            // Quick Sort
            startTime = DateTime.Now;
            QuickSort(quickArray, 0, quickArray.Length - 1);
            endTime = DateTime.Now;
            Console.WriteLine($"For Quick Sort: {endTime - startTime}");
        }

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no swapping occurred, array is already sorted
                if (!swapped)
                    break;
            }
        }

        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                // Sort first and second halves
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                // Merge the sorted halves
                Merge(array, left, mid, right);
            }
        }

        private static void Merge(int[] array, int left, int mid, int right)
        {
            // Find sizes of two subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temp arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temp arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[mid + 1 + j];

            // Merge the temp arrays back into array[left..right]
            int iIndex = 0, jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    array[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            // Copy remaining elements of leftArray[], if any
            while (iIndex < n1)
            {
                array[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            // Copy remaining elements of rightArray[], if any
            while (jIndex < n2)
            {
                array[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }

        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partitioning index
                int pi = Partition(array, low, high);

                // Recursively sort elements before and after partition
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            // Pivot (choosing the last element)
            int pivot = array[high];
            int i = low - 1; // Index of smaller element

            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or equal to pivot
                if (array[j] <= pivot)
                {
                    i++;
                    // Swap array[i] and array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Swap array[i+1] and array[high] (or pivot)
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
