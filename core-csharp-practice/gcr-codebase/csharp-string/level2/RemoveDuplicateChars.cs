using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class RemoveDuplicateChars
    {
        static string RemoveDuplicates(string text)
        {
            if (text == null)
                return "";

            char[] result = new char[text.Length];
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                bool isDuplicate = false;

                for (int j = 0; j < index; j++)
                {
                    if (result[j] == current)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result[index] = current;
                    index++;
                }
            }

            return new string(result, 0, index);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();

            string output = RemoveDuplicates(input);
            Console.WriteLine("After removing duplicates: " + output);
        }
    }
}
