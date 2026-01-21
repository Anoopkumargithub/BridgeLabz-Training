using System;
using System.Collections.Generic;

class FindFrequencyOfElements
{
    static Dictionary<T, int> FindFrequencies<T>(List<T> list)
    {
        Dictionary<T, int> frequencyDict = new Dictionary<T, int>();

        foreach (T item in list)
        {
            if (frequencyDict.ContainsKey(item))
            {
                frequencyDict[item]++;
            }
            else
            {
                frequencyDict[item] = 1;
            }
        }

        return frequencyDict;
    }

    static void Main(string[] args)
    {
        List<string> items = new List<string>
        {
            "apple", "banana", "apple", "orange", "banana", "apple"
        };

        Dictionary<string, int> frequencies = FindFrequencies(items);

        Console.WriteLine("Element Frequencies:");
        foreach (var kvp in frequencies)
        {
            Console.WriteLine(kvp.Key + " " + kvp.Value);
        }
    }
}