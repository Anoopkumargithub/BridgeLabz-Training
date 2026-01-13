using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_searching.stringbuilder
{
    internal class ReadUserInputandWritetoFile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Read User Input and Write to File Using StreamReader\r\n");
            Console.WriteLine();

            string filePath = "C:\\.Net\\BridgeLabzTraining\\csharp-searching\\stringbuilder\\UserInput.txt";

            try
            {

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    Console.WriteLine("Enter text to write to File: ");
                    Console.WriteLine();

                    string line;
                    while ((line = Console.ReadLine()) != "EXIT")
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Successfully Writeen On file.");

                // display file Contenet
                Console.WriteLine("--- File Content ---");

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
