using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class ArgumentOutOfRangeExceptionExample
    {
        static void DemonstrateArgumentOutOfRangeException(string str)
        {
            try
            {
                char chara = str[6];
                Console.WriteLine($"character at 6th index: {chara}");
            }
            catch (Exception e)
            {
                Console.WriteLine("ArgumentOutOfRangeException");
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            string str = "Hello";

            DemonstrateArgumentOutOfRangeException(str);

        }
    }
}
