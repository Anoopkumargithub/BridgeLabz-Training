/*
Thread has been created but Start() method has not been called.

Thread object exists in memory
No system resources allocated for execution yet
Thread is not schedulable
Transitions to Running when Start() is called

*/


using System;
using System.Threading;
class Program
{
static void SimpleTask()
{
Console.WriteLine("Task executing");
}
static void Main(string[] args)
{
Thread thread = new Thread(SimpleTask);
Console.WriteLine($"State after creation: {thread.ThreadState}");
// Output: Unstarted
thread.Start();
Console.WriteLine($"State after start: {thread.ThreadState}");

// Output: Running
thread.Join();
}
}