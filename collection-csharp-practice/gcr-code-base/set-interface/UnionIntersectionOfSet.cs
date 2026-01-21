using System;
using System.Collections.Generic;

class UnionIntersectionOfSet
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        // Union
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        // Intersection
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);

        Console.WriteLine("Union:");
        foreach (int val in unionSet)
            Console.Write(val + " ");

        Console.WriteLine("\nIntersection:");
        foreach (int val in intersectionSet)
            Console.Write(val + " ");
    }
}