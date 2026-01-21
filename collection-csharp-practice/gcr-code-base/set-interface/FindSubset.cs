using System;
using System.Collections.Generic;

class FIndSubset
{
    static void Main()
    {
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> superset = new HashSet<int> { 1, 2, 3, 4 };

        bool isSubset = subset.IsSubsetOf(superset);

        Console.WriteLine(isSubset);
    }
}