using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_sorting
{
    internal class SortStudent
    {
        static void Main(string[] args)
        {
            int[] marks = { 65, 90, 72, 88, 55 };

            Console.WriteLine("Student Marks Before Sorting:");
            DisplayArray(marks);

            BubbleSort(marks);

            Console.WriteLine("\nStudent Marks After Bubble Sort (Ascending Order):");
            DisplayArray(marks);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int mark in arr)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
