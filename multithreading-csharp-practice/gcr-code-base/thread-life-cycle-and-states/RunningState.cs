/*

Thread is executing or is ready to execute (in the scheduler queue).

Thread is actively executing code
May be scheduled by OS thread scheduler
Normal execution state
Value is 0 (Running = 0 in enum)

*/

using System;
using System.Threading;
class Program
{
static void LongRunningTask()
{
for (int i = 1; i <= 5; i++)
{
Console.WriteLine($"Working: {i}");
Thread.Sleep(500);
}
}
static void Main(string[] args)
{
Thread thread = new Thread(LongRunningTask);
thread.Start();
// Give thread time to start
Thread.Sleep(100);
Console.WriteLine($"Thread state: {thread.ThreadState}");
thread.Join();
}
}