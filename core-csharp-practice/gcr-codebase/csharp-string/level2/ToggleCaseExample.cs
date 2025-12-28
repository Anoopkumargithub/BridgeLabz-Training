using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class ToggleCaseExample
    {
        static string ToggleCase(string text)
        {
            if (text == null)
                return "";

            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    result[i] = (char)(ch + 32);
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    result[i] = (char)(ch - 32);
                }
                else
                {
                    result[i] = ch;
                }
                }

            return new string(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();

            string toggled = ToggleCase(input);
            Console.WriteLine("Toggled case: " + toggled);
        }
    }
}
