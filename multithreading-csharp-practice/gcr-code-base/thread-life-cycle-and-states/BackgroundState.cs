/*

Thread is marked as a background thread.

Can be combined with other states (it’s a flag)
Thread won’t prevent application termination
Set via IsBackground = true


*/

using System;
using System.Threading;
class Program
{
static void CheckStates()
{
Thread foregroundThread = new Thread(() => Thread.Sleep(1000));
Thread backgroundThread = new Thread(() => Thread.Sleep(1000));
backgroundThread.IsBackground = true;

foregroundThread.Start();
backgroundThread.Start();
Thread.Sleep(100);
Console.WriteLine($"Foreground state: {foregroundThread.ThreadState}");
// Output: WaitSleepJoin
Console.WriteLine($"Background state: {backgroundThread.ThreadState}");
// Output: Background, WaitSleepJoin (combined)
foregroundThread.Join();
backgroundThread.Join();
}
static void Main(string[] args)
{
CheckStates();
}
}