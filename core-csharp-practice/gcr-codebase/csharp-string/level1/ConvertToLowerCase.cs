using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class ConvertToLowerCase
    {
        static string ToLowerAscii(string str)
        {
            if (str == null) return "";

            char[] result = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    result[i] = (char)(ch + 32);
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
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();

            string AsciiLower = ToLowerAscii(str);
            string BuiltInLower = str.ToLower();

            Console.WriteLine("ASCII Lowercase   : " + AsciiLower);
            Console.WriteLine("Built-in ToLower(): " + BuiltInLower);
        }
    }
}
