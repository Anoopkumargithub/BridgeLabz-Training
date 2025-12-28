using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class NullReferenceExceptionExample
    {
        static void DemonstrateNullReferenceException(string text)
        {
            try
            {
                int length = text.Length;
                Console.WriteLine("Text Length " + length);
            }catch  (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException caught!");
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            string text = null;

            DemonstrateNullReferenceException(text);
        }
    }
}
