/*
Thread has been aborted (usually via Abort() method - deprecated).

Thread.Abort() is deprecated in .NET Core and .NET 5+
Use cancellation tokens instead
Can leave application in inconsistent state
Should be avoided in modern code


*/


using System;
using System.Threading;
class Program
{
static void AbortableTask()
{
try
{
for (int i = 1; i <= 10; i++)
{

Console.WriteLine($"Working: {i}");
Thread.Sleep(500);
}
}
catch (ThreadAbortException)
{
Console.WriteLine("Thread was aborted!");
}
}
static void Main(string[] args)
{
Thread thread = new Thread(AbortableTask);
thread.Start();
Thread.Sleep(2000);
#pragma warning disable SYSLIB0006 // Abort is obsolete
thread.Abort(); // Not recommended in modern .NET
#pragma warning restore SYSLIB0006
thread.Join();
Console.WriteLine($"Thread state: {thread.ThreadState}");
}
}