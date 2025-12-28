using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class CreateSubString
    {
        static string FindSubString(string str, int startIndex, int endIndex)
        {
            if (str == null) return "";

            if (startIndex < 0 || endIndex > str.Length || startIndex >= endIndex) return "";

            char[] result = new char[endIndex - startIndex];


            for (int i = 0; i < result.Length; i++)
            {
                result[i] = str[startIndex + i];
            }

            return new string(result);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter String starting index");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter String ending index");
            int endIndex = Convert.ToInt32(Console.ReadLine());

            string ResultSubString = FindSubString(str, startIndex, endIndex);
            Console.WriteLine("SubString by Method : " + ResultSubString);

            string ResultString = str.Substring(startIndex, endIndex);
            Console.WriteLine("SubString By .Substring(): " + ResultSubString);

        }
    }
}
