using System;
using System.Collections.Generic;

class InvertAMap
{
    static Dictionary<int, List<string>> InvertDictionary(
        Dictionary<string, int> input)
    {
        Dictionary<int, List<string>> inverted =
            new Dictionary<int, List<string>>();

        foreach (var pair in input)
        {
            if (!inverted.ContainsKey(pair.Value))
            {
                inverted[pair.Value] = new List<string>();
            }

            inverted[pair.Value].Add(pair.Key);
        }

        return inverted;
    }

    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Dictionary<int, List<string>> result = InvertDictionary(input);

        foreach (var entry in result)
        {
            Console.Write(entry.Key + " = [ ");
            foreach (var k in entry.Value)
                Console.Write(k + " ");
            Console.WriteLine("]");
        }
    }
}