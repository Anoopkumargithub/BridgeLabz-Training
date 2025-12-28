using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class PalindromeCheck
    {
        static bool IsPalindrome(string text)
        {
            if (text == null)
                return false;

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                char start = text[left];
                char end = text[right];

                if (start >= 'A' && start <= 'Z')
                    start = (char)(start + 32);

                if (end >= 'A' && end <= 'Z')
                    end = (char)(end + 32);

                if (start != end)
                    return false;

                left++;
                right--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
