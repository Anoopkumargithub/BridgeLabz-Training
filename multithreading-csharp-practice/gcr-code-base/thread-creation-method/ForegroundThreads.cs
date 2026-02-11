/*
Keep the application alive
Application won’t terminate until all foreground threads complete
Default type when creating threads
Used for critical operations that must complete
*/

using System;
using System.Threading;

class Program
{
static void ForegroundTask()
{
Console.WriteLine("Foreground thread started");
for (int i = 1; i <= 5; i++)
{
Console.WriteLine($"Foreground: {i}");
Thread.Sleep(1000);
}
Console.WriteLine("Foreground thread completed");
}
static void Main(string[] args)
{
Thread thread = new Thread(ForegroundTask);
// IsBackground is false by default (foreground)
Console.WriteLine($"Is Background: {thread.IsBackground}");
thread.Start();
Console.WriteLine("Main thread ending...");
// Application will wait for foreground thread to complete
}
}