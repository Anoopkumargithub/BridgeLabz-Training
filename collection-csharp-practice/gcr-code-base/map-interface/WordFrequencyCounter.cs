using System;
using System.Collections.Generic;

class WordFrequencyCounter
{
    static Dictionary<string, int> CountWordFrequencies(string text)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string lowerWord = word.ToLower();
            if (wordFrequency.ContainsKey(lowerWord))
            {
                wordFrequency[lowerWord]++;
            }
            else
            {
                wordFrequency[lowerWord] = 1;
            }
        }

        return wordFrequency;
    }

    static void Main()
    {
        string text = "Hello world! Hello everyone. Welcome to the world of C# programming.";
        Dictionary<string, int> frequencies = CountWordFrequencies(text);

        foreach (var pair in frequencies)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}