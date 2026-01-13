using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class ReadFileLinebyLineUsingStreamReader
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Read a File Line by Line Using StreamReader");
            Console.WriteLine();

            string filePath = "C:\\.Net\\BridgeLabzTraining\\csharp-searching\\stringbuilder\\SampleText.txt";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
