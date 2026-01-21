using System;
using System.Collections.Generic;

class RotateElement
{
    static List<int> RotateLeft(List<int> list, int k)
    {
        int n = list.Count;
        k = k % n;   // handle k > n

        List<int> rotated = new List<int>();

        // add elements from k to end
        for (int i = k; i < n; i++)
            rotated.Add(list[i]);

        // add first k elements
        for (int i = 0; i < k; i++)
            rotated.Add(list[i]);

        return rotated;
    }

    static void Main()
    {
        List<int> input = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        List<int> result = RotateLeft(input, rotateBy);

        foreach (int val in result)
            Console.Write(val + " ");
    }
}