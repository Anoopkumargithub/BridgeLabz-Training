using System;

class MoveZeroes
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid size");
            return;
        }

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        int index = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                arr[index++] = arr[i];
            }
        }

        while (index < n)
        {
            arr[index++] = 0;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
