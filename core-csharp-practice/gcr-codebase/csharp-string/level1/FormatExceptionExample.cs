using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class FormatExceptionExample
    {
        static void DemonstrateFormatException(string str)
        {
            try
            {
                int number = int.Parse(str);
                Console.WriteLine($"Number :  {number}");
            }
            catch (Exception e)
            {
                Console.WriteLine("FormatException");
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            string str = "Hello";
            DemonstrateFormatException(str);

        }
    }
}
