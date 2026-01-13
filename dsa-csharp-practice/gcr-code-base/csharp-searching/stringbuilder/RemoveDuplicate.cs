using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb = new StringBuilder(Remove(sb.ToString()));
            Console.WriteLine(sb.ToString());
        }

        public static string Remove(string sb)
        {
            if (string.IsNullOrEmpty(sb))
            {
                return sb;
            }

            StringBuilder result = new StringBuilder();
            HashSet<char> seenCharacters = new HashSet<char>();

            char[] chars = sb.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!seenCharacters.Contains(chars[i]))
                {
                    seenCharacters.Add(chars[i]);
                    result.Append(chars[i]);
                }
            }

            return result.ToString();
        }
    }
}
