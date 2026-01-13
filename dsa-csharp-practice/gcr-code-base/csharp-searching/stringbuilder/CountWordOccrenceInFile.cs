using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class CountWordOccrenceInFile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Count the Occurrence of a Word in a File Using StreamReader\n");
            Console.WriteLine();

            string filePath = "C:\\.Net\\BridgeLabzTraining\\csharp-searching\\stringbuilder\\SampleText.txt";


            Console.Write("Enter a Word to Search it's occueramnce: ");
            string searchWord = Console.ReadLine();
            Console.WriteLine();

            // finds the Occurence of each word
            int count = CountWordOccurence(filePath, searchWord);
            Console.WriteLine($"Occurence of \"{searchWord}\" is {count}");

        }

        public static int CountWordOccurence(string filePath, string searchWord)
        {
            int count = 0;

            // read file data and find occurance
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', '\t', '.', ',', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            bool isMatch = true ? word.Equals(searchWord, StringComparison.Ordinal) : word.Equals(searchWord, StringComparison.OrdinalIgnoreCase);

                            if (isMatch)
                            {
                                count++;
                            }
                        }
                    }
                    return count;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return count;
        }
    }
}
