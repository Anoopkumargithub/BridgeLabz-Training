using System;

class ArmstrongNumber
{
    static void Main()
    {
        
        Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());        
        int Sum = 0;
        int OriginalNumber = number;
        
        while (OriginalNumber != 0)
        {
            
            int Remainder = OriginalNumber % 10;            
            Sum = Sum + (Remainder * Remainder * Remainder);            
            originalNumber = OriginalNumber / 10;
        }
        
        if (Sum == Number)
        {
            Console.WriteLine($"{Number} is an Armstrong number");
        }
        else
        {
            Console.WriteLine($"{Number} is not an Armstrong number");
        }
    }
}
