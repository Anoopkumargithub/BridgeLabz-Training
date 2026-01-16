using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.traffic_manager
{
    internal class VehicleQueue
    {
        private string[] queue;
        private int front, rear, size;

        public VehicleQueue(int capacity)
        {
            queue = new string[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public void Enqueue(string vehicle)
        {
            if (size == queue.Length)
            {
                Console.WriteLine("Queue Overflow: Waiting area full");
                return;
            }

            rear = (rear + 1) % queue.Length;
            queue[rear] = vehicle;
            size++;
        }

        public string Dequeue()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue Underflow: No vehicles waiting");
                return null;
            }

            string vehicle = queue[front];
            front = (front + 1) % queue.Length;
            size--;
            return vehicle;
        }

        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Waiting Queue Empty");
                return;
            }

            Console.Write("Waiting Queue: ");
            for (int i = 0; i < size; i++)
                Console.Write(queue[(front + i) % queue.Length] + " ");
            Console.WriteLine();
        }
    }
}
