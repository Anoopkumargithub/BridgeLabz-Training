using System;
using System.Collections.Generic;

class RemoveDuplicateElement
{
    static List<int> RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }

        return result;
    }

    static void Main()
    {
        List<int> input = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> output = RemoveDuplicates(input);

        foreach (int val in output)
            Console.Write(val + " ");
    }
}