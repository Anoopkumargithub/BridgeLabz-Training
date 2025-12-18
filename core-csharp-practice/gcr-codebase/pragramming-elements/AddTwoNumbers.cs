using System;

class AddTwoNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int m = int.Parse(Console.ReadLine());

        int sum = n + m;

        Console.WriteLine($"Sum: {sum}");
    }
}
