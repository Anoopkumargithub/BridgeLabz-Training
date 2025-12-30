using System;

class BestTimeToBuySellStock
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid size");
            return;
        }

        int[] prices = new int[n];

        Console.WriteLine("Enter prices:");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out prices[i]);
        }

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < n; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            else
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }

        Console.WriteLine(maxProfit);
    }
}
