using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_sorting
{
    internal class SortEmployee
    {
        static void Main(string[] args)
        {
            int[] employeeIds = { 105, 101, 109, 103, 102 };

            Console.WriteLine("Employee IDs Before Sorting:");
            DisplayArray(employeeIds);

            InsertionSort(employeeIds);

            Console.WriteLine("\nEmployee IDs After Insertion Sort (Ascending Order):");
            DisplayArray(employeeIds);
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int id in arr)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
}
