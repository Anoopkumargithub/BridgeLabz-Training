using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class SubstringOccurrence
    {
        static int CountOccurrences(string text, string pattern)
        {
            if (text == null || pattern == null)
                return 0;

            if (pattern == "" || pattern.Length > text.Length)
                return 0;

            int count = 0;

            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter main string: ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter substring: ");
            string pattern = Console.ReadLine();

            int occurrences = CountOccurrences(text, pattern);
            Console.WriteLine("Occurrences: " + occurrences);
        }
    }
}
