using System;
using System.Threading;
class Program
{
static void CheckMultipleStates()
{
Thread thread = new Thread(() => Thread.Sleep(2000));
thread.IsBackground = true;
thread.Start();
Thread.Sleep(100);
ThreadState state = thread.ThreadState;
Console.WriteLine($"Current state: {state}");
Console.WriteLine($"Is Background: {(state & ThreadState.Background) != 0}");
Console.WriteLine($"Is WaitSleepJoin: {(state & ThreadState.WaitSleepJoin) != 0}");
Console.WriteLine($"Is Running: {state == ThreadState.Running}");
thread.Join();
}
static void Main(string[] args)
{
CheckMultipleStates();
}
}