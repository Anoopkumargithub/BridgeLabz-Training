using System;
using System.Threading;
class Program
{
static void StateTransitionDemo()
{
Console.WriteLine("Starting state transition demonstration...\n");
for (int i = 1; i <= 3; i++)
{
Console.WriteLine($"Iteration: {i}");
Thread.Sleep(1000);
}
}
static void Main(string[] args)
{
Thread thread = new Thread(StateTransitionDemo);
// State 1: Unstarted
Console.WriteLine($"1. After creation: {thread.ThreadState}");
Console.WriteLine($" IsAlive: {thread.IsAlive}\n");
thread.Start();
// State 2: Running
Thread.Sleep(100);
Console.WriteLine($"2. After start: {thread.ThreadState}");
Console.WriteLine($" IsAlive: {thread.IsAlive}\n");
// State 3: WaitSleepJoin
Thread.Sleep(500);
Console.WriteLine($"3. During sleep: {thread.ThreadState}");
Console.WriteLine($" IsAlive: {thread.IsAlive}\n");
// Wait for completion
thread.Join();
// State 4: Stopped
Console.WriteLine($"4. After completion: {thread.ThreadState}");
Console.WriteLine($" IsAlive: {thread.IsAlive}");
}
}