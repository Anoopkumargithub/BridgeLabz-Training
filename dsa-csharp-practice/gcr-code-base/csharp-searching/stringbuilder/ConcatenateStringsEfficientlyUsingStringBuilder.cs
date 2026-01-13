using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class ConcatenateStringsEfficientlyUsingStringBuilder
    {
        public static void Main(string[] args)
        {
            string[] strings = {
                "Hello",
                ", ",
                "welcome ",
                "BridgeLabz"
            };

            StringBuilder builder = new StringBuilder();
            foreach (string s in strings)
            {
                builder.Append(s);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
