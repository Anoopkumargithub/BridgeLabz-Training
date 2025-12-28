using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class CompareTwoString
    {
        static bool CompareString(string s1, string s2)
        {

            if ( ( s1.Length != s2.Length ) && (s1 == null || s2 == null) ) return false;
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i]) return false;
                }
            }
                    return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter String for Compare: ");
            string string2 = Console.ReadLine();

            bool Result = CompareString(string1, string2);
            Console.WriteLine(Result);
        }
    }
}
