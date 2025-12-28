using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level2
{
    internal class ReverseStringExample
    {
        static string ReverseString(string text)
        {
            if (text == null)
                return "";

            char[] reversed = new char[text.Length];
            int index = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed[index] = text[i];
                index++;
            }

            return new string(reversed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();

            string result = ReverseString(input);
            Console.WriteLine("Reversed string: " + result);
        }
    }
}
