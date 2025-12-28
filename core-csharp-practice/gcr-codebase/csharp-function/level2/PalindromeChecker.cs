using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level2
{
    internal class PalindromeChecker
    {
        static string ReadInput()
        {
            Console.Write("Enter a string: ");
            return Console.ReadLine();
        }

        static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {

                if (text[left] == ' ')
                {
                    left++;
                    continue;
                }

                if (text[right] == ' ')
                {
                    right--;
                    continue;
                }

                char l = char.ToLower(text[left]);
                char r = char.ToLower(text[right]);

                if (l != r)
                    return false;

                left++;
                right--;
            }

            return true;
        }

        static void DisplayResult(string text, bool isPalindrome)
        {
            if (isPalindrome)
                Console.WriteLine($"{text} is a PALINDROME");
            else
                Console.WriteLine($"{text} is NOT a palindrome");
        }

        static void Main(string[] args)
        {
            string input = ReadInput();
            bool result = IsPalindrome(input);
            DisplayResult(input, result);
        }
    }
}
