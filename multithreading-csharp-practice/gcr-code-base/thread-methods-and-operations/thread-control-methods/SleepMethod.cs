/*

Static method - suspends current thread
Doesn’t release locks
Throws ThreadInterruptedException if interrupted
Sleep(0) yields to threads of equal or higher priority
*/


using System;
using System.Threading;
class Program
{
static void SleepDemo()
{

Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started at
{DateTime.Now:HH:mm:ss.fff}");
Thread.Sleep(2000); // Sleep for 2 seconds
Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} resumed at
{DateTime.Now:HH:mm:ss.fff}");
// Sleep for 0 - yields to other threads
Thread.Sleep(0);
// Sleep indefinitely (until interrupted)
// Thread.Sleep(Timeout.Infinite);
}
static void Main(string[] args)
{
Thread thread = new Thread(SleepDemo);
thread.Start();
thread.Join();
}
}