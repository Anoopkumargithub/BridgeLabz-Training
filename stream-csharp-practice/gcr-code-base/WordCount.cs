using System;
using System.IO;

class WordCountDemo
{
    static void Main()
    {
        string filePath = "file2.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        try
        {
            StreamReader reader = new StreamReader(filePath);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                // Split words (space + punctuation)
                string[] words = line
                    .ToLower()
                    .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '"', '(', ')', '-' },
                           StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }

            reader.Close();

            // Sort by frequency (descending) and take top 5
            var topWords = wordCount
                .OrderByDescending(x => x.Value)
                .Take(5);

            Console.WriteLine("Top 5 most frequent words:");
            foreach (var item in topWords)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
