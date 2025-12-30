using System;

class TwoSum
{
    static void Main()
    {
        // Read size of array
        Console.WriteLine("Enter size of array:");
        string inputSize = Console.ReadLine();

        if (!int.TryParse(inputSize, out int n) || n <= 0)
        {
            Console.WriteLine("Invalid array size");
            return;
        }

        int[] arr = new int[n];

        // Read array elements
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        // Read target sum
        Console.WriteLine("Enter target sum:");
        string inputTarget = Console.ReadLine();

        if (!int.TryParse(inputTarget, out int target))
        {
            Console.WriteLine("Invalid target");
            return;
        }

        // Find indices of two numbers whose sum equals target
        bool found = false;

        for (int i = 0; i < n && !found; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine($"{i} {j}");
                    found = true;
                    break;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No pair found");
        }
    }
}
