using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_sorting
{
    internal class SortProductPrice
    {
        static void Main(string[] args)
        {
            int[] prices = { 999, 299, 499, 199, 799 };

            Console.WriteLine("Product Prices Before Sorting:");
            DisplayArray(prices);

            QuickSort(prices, 0, prices.Length - 1);

            Console.WriteLine("\nProduct Prices After Quick Sort (Ascending Order):");
            DisplayArray(prices);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}
