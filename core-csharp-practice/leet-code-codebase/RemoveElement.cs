using System;

class RemoveElement
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        string inputSize = Console.ReadLine();

        if (!int.TryParse(inputSize, out int n) || n <= 0)
        {
            Console.WriteLine("Invalid array size");
            return;
        }

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        Console.WriteLine("Enter element to remove:");
        string inputVal = Console.ReadLine();

        if (!int.TryParse(inputVal, out int val))
        {
            Console.WriteLine("Invalid element");
            return;
        }

        int k = 0;

        Array.Sort(arr);

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != val)
            {
                k++;
            }
        }

        Console.WriteLine(k);
    }
}
