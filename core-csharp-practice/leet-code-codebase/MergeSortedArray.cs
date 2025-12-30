using System;

class MergeSortedArray
{
    static void Main()
    {
        // Read size of first array
        Console.WriteLine("Enter size of first array:");
        string input1 = Console.ReadLine();

        // Read size of second array
        Console.WriteLine("Enter size of second array:");
        string input2 = Console.ReadLine();

        if (!int.TryParse(input1, out int n1) || !int.TryParse(input2, out int n2))
        {
            Console.WriteLine("Invalid array size input");
            return;
        }

        int[] arr1 = new int[n1 + n2];
        int[] arr2 = new int[n2];

        // Read elements of first array
        Console.WriteLine("Enter elements of first array:");
        for (int i = 0; i < n1; i++)
        {
            int.TryParse(Console.ReadLine(), out arr1[i]);
        }

        // Read elements of second array
        Console.WriteLine("Enter elements of second array:");
        for (int i = 0; i < n2; i++)
        {
            int.TryParse(Console.ReadLine(), out arr2[i]);
        }

        // Merge arrays
        Merge(arr1, n1, arr2, n2);
    }

    static void Merge(int[] arr1, int m, int[] arr2, int n)
    {
        int k = m;

        for (int i = 0; i < n; i++)
        {
            arr1[k++] = arr2[i];
        }

        Array.Sort(arr1);

        Console.WriteLine("Merged and Sorted Array:");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
    }
}
