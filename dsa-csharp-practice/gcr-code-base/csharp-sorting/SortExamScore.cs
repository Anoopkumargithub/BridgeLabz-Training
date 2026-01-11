using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_sorting
{
    internal class SortExamScore
    {
        static void Main(string[] args)
        {
            int[] scores = { 78, 45, 90, 66, 82 };

            Console.WriteLine("Exam Scores Before Sorting:");
            DisplayArray(scores);

            SelectionSort(scores);

            Console.WriteLine("\nExam Scores After Selection Sort (Ascending Order):");
            DisplayArray(scores);
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int score in arr)
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
        }
    }
}
