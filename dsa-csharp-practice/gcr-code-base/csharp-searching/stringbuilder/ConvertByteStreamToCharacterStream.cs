using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class ConvertByteStreamToCharacterStream
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Convert Byte Stream to Character Stream Using StreamReader");
            Console.WriteLine();

            string filePath = "C:\\.Net\\BridgeLabzTraining\\csharp-searching\\stringbuilder\\SampleText.txt";

            try
            {
                // Read binary data and convert to characters
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string content = sr.ReadToEnd();
                        Console.WriteLine("--- File Content (from byte stream) ---");
                        Console.WriteLine(content);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Successfully converted byte stream to character stream.");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
