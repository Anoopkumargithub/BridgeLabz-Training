using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class ConvertToUpperCase
    {
        static string ToUpperAscii(string str)
        {
            if (str == null) return "";

            char[] result = new char[str.Length];

            for(int i = 0; i<str.Length; i++)
            {
                char ch = str[i];

                if(ch >= 'a' && ch <= 'z')
                {
                    result[i] = (char) (ch - 32);
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

            string AsciiUpper = ToUpperAscii(str);
            string BuiltInUpper = str.ToUpper();

            Console.WriteLine("ASCII Uppercase   : " + AsciiUpper);
            Console.WriteLine("Built-in ToUpper(): " + BuiltInUpper);
        }
    }
}
