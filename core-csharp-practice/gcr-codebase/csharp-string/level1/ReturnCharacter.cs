using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpstring.level1
{
    internal class RturnCharacter
    {
        static char[] FindCharacter(string str)
        {
            char[] character = new char[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                character[i] = str[i];
            }
            return character;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            char[] characters = FindCharacter(str);

            char[] result = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (characters[i] != result[i])
                {
                    Console.WriteLine("Both Results are different");
                }
                else
                {
                    Console.WriteLine($"{characters[i]} == {result[i]}");
                }
            }

        }
    }
}
