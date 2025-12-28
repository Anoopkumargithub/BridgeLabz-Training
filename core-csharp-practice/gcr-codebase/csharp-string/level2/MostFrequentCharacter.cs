using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class MostFrequentCharacter
    {
        static char FindMostFrequentChar(string text)
        {
            if (string.IsNullOrEmpty(text))
                return '\0';

            int[] frequency = new int[256]; // ASCII size

            for (int i = 0; i < text.Length; i++)
            {
                frequency[text[i]]++;
            }

            int maxCount = 0;
            char result = '\0';

            for (int i = 0; i < text.Length; i++)
            {
                if (frequency[text[i]] > maxCount)
                {
                    maxCount = frequency[text[i]];
                    result = text[i];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();

            char mostFrequent = FindMostFrequentChar(input);

            if (mostFrequent != '\0')
                Console.WriteLine("Most Frequent Character: '" + mostFrequent + "'");
            else
                Console.WriteLine("Invalid input");
        }
    }
}
