// A delegate that represents a method to be executed on a thread without parameters.

using System;
using System.Threading;
class Program
{
static void DisplayMessage()
{
Console.WriteLine($"Executing on thread: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
}

static void Main(string[] args)
{
// Explicit delegate creation
ThreadStart ts = new ThreadStart(DisplayMessage);
Thread thread = new Thread(ts);
thread.Name = "DisplayThread";
thread.Start();
thread.Join();
// Simplified syntax
Thread thread2 = new Thread(DisplayMessage);
thread2.Name = "DisplayThread2";
thread2.Start();
thread2.Join();
}
}