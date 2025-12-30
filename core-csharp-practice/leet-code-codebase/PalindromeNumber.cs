using System;

class PalindromeNumber
{
    static void Main()
    {
        // Read input from user
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            bool result = IsPalindrome(number);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    static bool IsPalindrome(int x)
    {
        // Negative numbers are not palindrome
        if (x < 0)
        {
            return false;
        }

        int rev = 0;
        int original = x;

        // Reverse the number
        while (x > 0)
        {
            int rem = x % 10;
            rev = rev * 10 + rem;
            x = x / 10;
        }

        return original == rev;
    }
}
