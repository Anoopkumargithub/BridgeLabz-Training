using System;

class RemoveDuplicatesFromSortedArray
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        string inputSize = Console.ReadLine();

        if (!int.TryParse(inputSize, out int n) || n <= 0)
        {
            Console.WriteLine("Invalid size");
            return;
        }

        int[] arr = new int[n];

        Console.WriteLine("Enter sorted array elements:");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        int result = RemoveDuplicates(arr);
        Console.WriteLine(result);
    }

    static int RemoveDuplicates(int[] arr)
    {
        int index = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                arr[index] = arr[i];
                index++;
            }
        }

        return index;
    }
}
