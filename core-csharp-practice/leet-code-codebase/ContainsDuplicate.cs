using System;

class ContainsDuplicate
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

        Array.Sort(arr);

        bool duplicate = false;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                duplicate = true;
                break;
            }
        }

        Console.WriteLine(duplicate);
    }
}
