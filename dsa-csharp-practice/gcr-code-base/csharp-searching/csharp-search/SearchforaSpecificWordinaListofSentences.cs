using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.csharp_linear_search
{
    internal class SearchforaSpecificWordinaListofSentences
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Search for a Specific Word in a List of Sentences");
            Console.WriteLine();

            string sentences = "Welcome to the BridgeLabz Training Program";

            Console.WriteLine("Entetr a word for search: ");
            string word = Console.ReadLine();
            Console.WriteLine();

            // Search for the word and get result
            string result = SearchWord(sentences, word);
            Console.WriteLine(result);

        }

        public static string SearchWord(string sentence, string searchWord)
        {
            // Split sentence into words
            string[] words = sentence.Split(new char[] { ' ', '\t', '.', ',', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Linear search for the word
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                {
                    return $"Word \"{searchWord}\" found at position {i + 1} in the sentence.";
                }
            }

            return $"Word \"{searchWord}\" not found in the sentence.";
        }
    }
}
