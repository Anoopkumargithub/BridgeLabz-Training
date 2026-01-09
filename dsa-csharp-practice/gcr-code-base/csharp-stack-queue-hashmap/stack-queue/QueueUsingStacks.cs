using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_stack_queue_hashmap.stack_queue
{
    internal class QueueUsingStacks
    {
        internal class Stack
        {
            private int[] arr;
            private int top;
            private int size;

            public Stack(int size)
            {
                this.size = size;
                arr = new int[size];
                top = -1;
            }

            public bool IsEmpty()
            {
                return top == -1;
            }

            public bool IsFull()
            {
                return top == size - 1;
            }

            public void Push(int value)
            {
                if (IsFull())
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }
                arr[++top] = value;
            }

            public int Pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return -1;
                }
                return arr[top--];
            }

            public int Peek()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                return arr[top];
            }
        }

        // Queue using two stacks
        internal class QueueUsingTwoStacks
        {
            private Stack stack1; // enqueue
            private Stack stack2; // dequeue

            public QueueUsingTwoStacks(int size)
            {
                stack1 = new Stack(size);
                stack2 = new Stack(size);
            }

            // Enqueue operation
            public void Enqueue(int value)
            {
                stack1.Push(value);
                Console.WriteLine("Enqueued: " + value);
            }

            // Dequeue operation
            public void Dequeue()
            {
                if (stack2.IsEmpty())
                {
                    while (!stack1.IsEmpty())
                    {
                        stack2.Push(stack1.Pop());
                    }
                }

                if (stack2.IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                }
                else
                {
                    Console.WriteLine("Dequeued: " + stack2.Pop());
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                QueueUsingTwoStacks queue = new QueueUsingTwoStacks(5);

                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);

                queue.Dequeue();
                queue.Dequeue();

                queue.Enqueue(40);
                queue.Enqueue(50);

                queue.Dequeue();
                queue.Dequeue();
                queue.Dequeue();
            }
        }
    }
}
