using System;

class Program
{
    static void Main(String[] args)
    {
        //  take user input
        Console.WriteLine("Enter a Word1: ");
        string word1 = Console.ReadLine();
        Console.WriteLine("Enter a Word2: ");
        string word2 = Console.ReadLine();


        // Requirement 1 -> Check if the second word is a reversed version of the first word 
        if(Requirement1(word1, word2)){
        Console.WriteLine("The second word is a reversed version of the first word.");
        // Requirement 2 ->  If the second word is the reversed version of the first word: 

        // Reverse the word
        string transformedWord = Reverse(word1);
        transformedWord = transformedWord.ToLower();
        // Relace vowels with '@'
        transformedWord = ReplaceVowels(transformedWord);
        Console.WriteLine("Transformed Word: " + transformedWord);
        }
        else
        {
            Console.WriteLine("The second word is NOT a reversed version of the first word.");

            // Requirement 3 -> If the second word is NOT the reversed version of the first word:
            
            // Step 1: Combine the first and second words into a single word (first word + second word).
            string combinedWord = word1 + word2;

            // Step 2: Convert the combined word to uppercase.
            string combinedWordUpper = combinedWord.ToUpper();

            // Step 3: Count the number of vowels and consonants separately in the uppercase word.
            int currentVowelsCount = 0;
            int currentConsonantsCount = 0;
            char[] upperVowels = { 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in combinedWordUpper)
            {
                if (char.IsLetter(c)) // Only consider letters for counting
                {
                    if (Array.IndexOf(upperVowels, c) >= 0)
                    {
                        currentVowelsCount++;
                    }
                    else
                    {
                        currentConsonantsCount++;
                    }
                }
            }

            Console.WriteLine($"Combined Word: {combinedWordUpper}");
            Console.WriteLine($"Vowels count: {currentVowelsCount}");
            Console.WriteLine($"Consonants count: {currentConsonantsCount}");

            // Step 4: Use a helper function for conditional printing
            ProcessCombinedWord(combinedWordUpper, currentVowelsCount, currentConsonantsCount);
        }
    }

    // helper function to check if word2 is the reverse of word1
    static bool Requirement1(string word1, string word2)
    {
        char[] charArray = word1.ToCharArray();
        Array.Reverse(charArray);
        string reversedWord1 = new string(charArray);
        if (reversedWord1.Equals(word2, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        else return false;
    }

    // Reverse function
    static string Reverse(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Replace vowels function
    static string ReplaceVowels(string word)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder(word);
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < sb.Length; i++)
        {
            if (Array.IndexOf(vowels, sb[i]) >= 0)
            {
                sb[i] = '@';
            }
        }
        word = sb.ToString();
        return word;
    }

}