using System;
using System.Text;
using System.Linq;

class FlipKeyUtility
{
    public string CleanseAndInvert(string input)
    {
        if(input == null || input.Length < 6)
        {
            return "";
        }

        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return "";
            }
        }

        string inputLowercase = input.ToLower();

        StringBuilder oddAsciiChars = new StringBuilder();
        foreach (char c in inputLowercase)
        {
            if (c % 2 != 0) // Check if ASCII value is odd
            {
                oddAsciiChars.Append(c);
            }
        }

        string reversedString = new string(oddAsciiChars.ToString().Reverse().ToArray());

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < reversedString.Length; i++)
        {
            if (i % 2 == 0) // Even position (0-based index)
            {
                result.Append(char.ToUpper(reversedString[i]));
            }
            else
            {
                result.Append(reversedString[i]);
            }
        }
        return result.ToString();    
    }
}