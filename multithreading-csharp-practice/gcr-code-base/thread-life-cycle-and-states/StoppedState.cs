/*
Thread has completed execution successfully.


Thread method has returned normally
Cannot be restarted
IsAlive returns false
Thread object still exists but is not executing

*/

using System;
using System.Threading;
class Program
{
static void QuickTask()
{
Console.WriteLine("Task starting");
Thread.Sleep(1000);
Console.WriteLine("Task completed");
}
static void Main(string[] args)
{
Thread thread = new Thread(QuickTask);
thread.Start();
thread.Join(); // Wait for completion
Console.WriteLine($"Thread state: {thread.ThreadState}");
// Output: Stopped
Console.WriteLine($"Is alive: {thread.IsAlive}");
// Output: False
}
}