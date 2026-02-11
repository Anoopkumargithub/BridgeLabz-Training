/*

Thread is blocked due to a call to Sleep(), Wait(), or Join().

Characteristics:

Thread is waiting for a specific condition
Not consuming CPU resources
Can be interrupted using Interrupt() method
Automatically returns to Running when condition is met

Methods that cause WaitSleepJoin:
Thread.Sleep(milliseconds)
Thread.Join()
Monitor.Wait()
Waiting on synchronization objects

*/

using System;
using System.Threading;
class Program
{
static void SleepingTask()
{
Console.WriteLine("Going to sleep...");
Thread.Sleep(5000);
Console.WriteLine("Woke up!");
}
static void Main(string[] args)
{
Thread thread = new Thread(SleepingTask);
thread.Start();
Thread.Sleep(500); // Give it time to enter sleep
Console.WriteLine($"Thread state: {thread.ThreadState}");
// Output: WaitSleepJoin
thread.Join();
Console.WriteLine("Thread completed");
}
}