using System;
using System.Threading;
class Program
{
static void PriorityTask(object priority)
{
long counter = 0;
DateTime start = DateTime.Now;
while ((DateTime.Now - start).TotalMilliseconds < 1000)
{
counter++;
}
Console.WriteLine($"{priority} Priority: {counter:N0} iterations");
}
static void Main(string[] args)
{
Thread lowPriority = new Thread(PriorityTask);
Thread normalPriority = new Thread(PriorityTask);
Thread highPriority = new Thread(PriorityTask);
lowPriority.Priority = ThreadPriority.Lowest;
normalPriority.Priority = ThreadPriority.Normal;
highPriority.Priority = ThreadPriority.Highest;

Console.WriteLine("Starting priority test...");
lowPriority.Start("Lowest");
normalPriority.Start("Normal");
highPriority.Start("Highest");
lowPriority.Join();
normalPriority.Join();
highPriority.Join();
Console.WriteLine("Priority test completed");
}
}

// Priority Levels:
public enum ThreadPriority
{
Lowest = 0,
BelowNormal = 1,
Normal = 2, // Default
AboveNormal = 3,
Highest = 4
}