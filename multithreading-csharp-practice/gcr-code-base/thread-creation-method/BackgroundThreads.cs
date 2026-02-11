/*
Don’t keep application alive
Application terminates when all foreground threads complete (background threads
are aborted)
Set using IsBackground = true
Used for non-critical background operations
Automatically terminated when application exits
*/


using System;
using System.Threading;
class Program
{
static void BackgroundTask()
{
Console.WriteLine("Background thread started");
for (int i = 1; i <= 10; i++)
{
Console.WriteLine($"Background: {i}");
Thread.Sleep(1000);
}
Console.WriteLine("Background thread completed"); // May not execute
}
static void Main(string[] args)
{
Thread thread = new Thread(BackgroundTask);
thread.IsBackground = true; // Set as background thread
Console.WriteLine($"Is Background: {thread.IsBackground}");
thread.Start();
Thread.Sleep(3000); // Main thread sleeps for 3 seconds
Console.WriteLine("Main thread ending...");
// Application will terminate, killing the background thread
}
}
