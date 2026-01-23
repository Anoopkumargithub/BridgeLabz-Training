using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Enter numbers only");
        }
    }
}
