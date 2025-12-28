using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class DispalyWordLength
    {
        static int GetLength(string text)
        {
            int count = 0;

            foreach (char c in text)
            {
                count++;
            }

            return count;
        }

        static object[,] SplitWordsWithLengths(string text)
        {
            if (text == null) return new object[0, 0];

            int textLength = GetLength(text);

            int wordCount = 0;
            bool inWord = false;

            for (int i = 0; i < textLength; i++)
            {
                if (text[i] != ' ' && !inWord)
                {
                    wordCount++;
                    inWord = true;
                }
                else if (text[i] == ' ')
                {
                    inWord = false;
                }
            }

            object[,] result = new object[wordCount, 2];

            int row = 0;
            string currentWord = "";

            for (int i = 0; i < textLength; i++)
            {
                if (text[i] != ' ')
                {
                    currentWord += text[i];
                }
                else if (currentWord != "")
                {
                    result[row, 0] = currentWord;
                    result[row, 1] = GetLength(currentWord);
                    row++;
                    currentWord = "";
                }
            }

            if (currentWord != "")
            {
                result[row, 0] = currentWord;
                result[row, 1] = GetLength(currentWord);
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            object[,] words = SplitWordsWithLengths(input);

            Console.WriteLine("Word Length");

            for (int i = 0; i < words.GetLength(0); i++)
            {
                Console.WriteLine(words[i, 0] + " " + words[i, 1]);
            }
        }
    }
}
