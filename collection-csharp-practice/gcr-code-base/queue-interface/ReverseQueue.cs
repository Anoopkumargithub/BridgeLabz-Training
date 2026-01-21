using System;
using System.Collections.Generic;

class ReverseQueue
{
    static Queue<int> Reverse(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Queue<int> reversedQueue = Reverse(queue);

        while (reversedQueue.Count > 0)
        {
            Console.Write(reversedQueue.Dequeue() + " ");
        }
    }
}