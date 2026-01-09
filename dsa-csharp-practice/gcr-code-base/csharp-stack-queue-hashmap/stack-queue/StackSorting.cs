using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_stack_queue_hashmap.stack_queue
{
    internal class StackSorting
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
        
            stack.Push(30);
            stack.Push(10);
            stack.Push(50);
            stack.Push(20);
            stack.Push(40);
        
            Console.WriteLine("Original Stack:");
            PrintStack(stack);
        
            SortStack(stack);
        
            Console.WriteLine("\nSorted Stack (Ascending Order):");
            PrintStack(stack);
        }
        
        // Recursive method to sort the stack
        static void SortStack(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;
        
            int top = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, top);
        }
        
        // Recursive method to insert element in sorted order
        static void InsertSorted(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }
        
            int temp = stack.Pop();
            InsertSorted(stack, value);
            stack.Push(temp);
        }
        
        // Utility method to print stack elements
        static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
