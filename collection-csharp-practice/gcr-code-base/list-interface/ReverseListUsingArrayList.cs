using System;
using System.Collections;

class ReverseListUsingArrayList
{

    static void ReverseArrayList(ArrayList arrayList)
    {
        int left = 0;
        int right = arrayList.Count - 1;

        while (left < right)
        {
            // Swap elements
            object temp = arrayList[left];
            arrayList[left] = arrayList[right];
            arrayList[right] = temp;

            left++;
            right--;
        }
    }
    static void Main(string[] args)
    {
        ArrayList numbers = new ArrayList {1,2,3,4,5};
        Console.WriteLine("Original ArrayList: ");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        // reverse ArrayList
        ReverseArrayList(numbers);

        Console.WriteLine("\nReversed ArrayList: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
