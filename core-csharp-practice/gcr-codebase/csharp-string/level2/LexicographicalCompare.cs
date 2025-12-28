using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class LexicographicalCompare
    {
        static int CompareStrings(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return 0;

            int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;

            for (int i = 0; i < minLength; i++)
            {
                if (s1[i] < s2[i])
                    return -1; // s1 comes before s2
                else if (s1[i] > s2[i])
                    return 1;  // s1 comes after s2
            }

            if (s1.Length < s2.Length)
                return -1;
            else if (s1.Length > s2.Length)
                return 1;
            else
                return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter String 1: ");
            string s1 = Console.ReadLine();

            Console.Write("Enter String 2: ");
            string s2 = Console.ReadLine();

            int result = CompareStrings(s1, s2);

            if (result < 0)
                Console.WriteLine($"{s1} comes before {s2} in lexicographical order");
            else if (result > 0)
                Console.WriteLine($"{s1} comes after {s2} in lexicographical order");
            else
                Console.WriteLine("Both strings are equal");
        }
    }
}
