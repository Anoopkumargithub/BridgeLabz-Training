using System;

class AddTwoNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine(args[0]);
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int m = int.Parse(Console.ReadLine());

        int sum = n + m;

        Console.WriteLine("Sum: " + sum);
    }
}
