using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class VowelConsonantCount
    {
        static void CountVowelsAndConsonants(string text)
        {
            if (text == null)
            {
                Console.WriteLine("Vowels: 0");
                Console.WriteLine("Consonants: 0");
                return;
            }

            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }

                if (ch >= 'a' && ch <= 'z')
                {
                    
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            CountVowelsAndConsonants(input);
        }
    }
}
