using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class StringFormater
    {
        static void Flow()
        {
            Console.WriteLine("-----Analyzer FLow-----");
            Console.WriteLine("1. Add One Space After Punctuaion");
            Console.WriteLine("2. Capital letter after period/question/exclamation marks");
            Console.WriteLine("3.Trimmed extra spaces");

        }

        static string AddSpace(string paragraph)
        {
            string newParagraph = "";
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (paragraph[i] == ',' || paragraph[i] == '.' || paragraph[i] == '!' || paragraph[i] == '?')
                {
                    newParagraph += paragraph[i] + " ";
                }
                else
                {
                    newParagraph += paragraph[i];
                }
            }
            return newParagraph;
        }

        static string CapitalLetter(string paragraph)
        {
            string newparagraph = "";
            bool isPunctuaion = false;
            for (int i = 0; i < paragraph.Length; i++)
            {
                if ((isPunctuaion) && (paragraph[i] >= 'a' && paragraph[i] <= 'z') && (paragraph[i] >= 'A' || paragraph[i] <= 'Z'))
                {
                    if (paragraph[i] >= 'a' && paragraph[i] <= 'z')
                    {
                        char ch = (char)paragraph[i];
                        newparagraph += (char)(ch - 32);
                    }
                    isPunctuaion = false;
                }
                else if (paragraph[i] == ',' || paragraph[i] == '.' || paragraph[i] == '!' || paragraph[i] == '?')
                {
                    newparagraph += paragraph[i] + " ";
                    isPunctuaion = true;
                }
                else
                {
                    newparagraph += paragraph[i];
                }

            }
            return newparagraph;
        }

        static string TrimmedSpace(string paragraph)
        {

            string newParagraph = "";
            bool isPunctuaion = false;
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (paragraph[i] == ',' || paragraph[i] == '.' || paragraph[i] == '!' || paragraph[i] == '?')
                {
                    newParagraph += paragraph[i];
                    isPunctuaion = true;
                }
                else if ((isPunctuaion))
                {
                    while (isPunctuaion)
                    {
                        char ch = paragraph[i];
                        if (ch != ' ')
                        {
                            newParagraph += " " + paragraph[i];
                            isPunctuaion = false;
                            break;
                        }
                        i++;
                    }
                }
                else
                {
                    newParagraph += paragraph[i];
                }
            }
            return newParagraph;

        }

        static string[] CountWords(string paragraph)
        {
            string[] words = new string[paragraph.Length];
            string dummy = "";
            int idx = 0;
            for (int i = 0; i < paragraph.Length; i++)
            {
                char ch = (char)paragraph[i];
                if (ch == ' ' || i == paragraph.Length)
                {
                    words[idx] = dummy;
                    idx++;
                    dummy = "";
                }
                else dummy += ch; 
            }
            Console.WriteLine($"Words count: {words.Length}");
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"word {i}: {words[i]}");
            }
            return words;

        }

        //static void LogestWords(string[] words)
        //{
        //    int wordsLength = 0;
        //    int idx = 0;
        //    for(int i = 0;i < words.Length;i++)
        //    {
        //        string word = words[i];
        //        int length = word.Length;
        //        if(length > wordsLength)
        //        {
        //            wordsLength = length;
        //            idx = i;
        //        }
        //    }
        //    Console.WriteLine($"Longest Word is {words[idx]} and it's length is {wordsLength}");
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Paragraph: ");
            string paragraph = Console.ReadLine();

            Flow();
            string addSpaceParagraph = AddSpace(paragraph);
            Console.WriteLine("Add Space: " + addSpaceParagraph);
            string capitalLetterParagraph = CapitalLetter(addSpaceParagraph);
            Console.WriteLine("Capital Letter: " + capitalLetterParagraph);
            string trimmedSpaceParagraph = TrimmedSpace(capitalLetterParagraph);
            Console.WriteLine("Trimmed: " + trimmedSpaceParagraph);
            string [] words = CountWords(trimmedSpaceParagraph);
            //LogestWords(words;

        }
    }
}
