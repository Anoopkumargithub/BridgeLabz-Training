/*

Throws ThreadInterruptedException in blocked thread
Only works on threads in WaitSleepJoin state
Preferred way to wake a sleeping thread

*/

using System;
using System.Threading;
class Program
{
static void InterruptibleTask()
{
try
{
Console.WriteLine("Thread starting long sleep...");
Thread.Sleep(10000); // 10 seconds
Console.WriteLine("Sleep completed normally");
}
catch (ThreadInterruptedException)
{
Console.WriteLine("Thread was interrupted during sleep!");
}
}
static void Main(string[] args)

{
Thread thread = new Thread(InterruptibleTask);
thread.Start();
Thread.Sleep(2000); // Wait 2 seconds
Console.WriteLine("Interrupting the thread...");
thread.Interrupt();
thread.Join();
Console.WriteLine("Main completed");
}
}
