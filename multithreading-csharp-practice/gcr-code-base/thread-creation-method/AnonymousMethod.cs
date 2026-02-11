using System;
using System.Threading;
class Program
{
static void Main(string[] args)
{
string message = "Hello from anonymous method!";
Thread thread = new Thread(delegate()
{
Console.WriteLine(message);
Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
});

thread.Start();
thread.Join();
}
}