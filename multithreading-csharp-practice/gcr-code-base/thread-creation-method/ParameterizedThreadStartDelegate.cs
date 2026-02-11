// A delegate that represents a method to be executed on a thread with an object parameter.

using System;
using System.Threading;
class Program
{
static void ProcessData(object data)
{
if (data is int number)
{
Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} processing:
{number}");
int result = number * number;
Console.WriteLine($"Result: {result}");
}
}
static void Main(string[] args)
{
Thread thread1 = new Thread(new ParameterizedThreadStart(ProcessData));
Thread thread2 = new Thread(ProcessData); // Simplified
thread1.Start(5);
thread2.Start(10);

thread1.Join();
thread2.Join();
}
}