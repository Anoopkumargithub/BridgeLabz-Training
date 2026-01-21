using System;
using System.Collections.Generic;

class ReverseListUsingLinkedList
{
    static LinkedList<int> ReversedList(LinkedList<int> linkedList)
    {
        LinkedList<int> reversedList = new LinkedList<int>();
        var currentNode = linkedList.Last;

        while (currentNode != null)
        {
            reversedList.AddLast(currentNode.Value);
            currentNode = currentNode.Previous;
        }

        return reversedList;
    }
    static void Main(StringContent[] args)
    {
        LinkedList<int> numbers = new LinkedList<>();
        numbers.AddLast(1);
        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.AddLast(4);
        numbers.AddLast(5);

        // Original LinkedList
        Console.WriteLine("Original LinkedList: ");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        // Reverse LinkedList
        LinkedList<int> reversedList = ReversedList(numbers);
        Console.WriteLine("\nReversed LinkedList: ");
        foreach (var number in reversedList)
        {
            Console.Write(number + " ");
        }
    }
}