/*

--------Use Foreground Threads for:-------------
Database transactions
File writing operations
Critical data processing
Operations that must complete
User-initiated important tasks

--------Use Background Threads for:-------------
Logging and monitoring
Cache cleanup
Periodic maintenance tasks
Non-essential background processing
Auto-save features (with proper handling)

*/

using System;
using System.Threading;
class Program
{
static void CriticalOperation()
{
Console.WriteLine("[CRITICAL] Starting critical data save...");
for (int i = 1; i <= 5; i++)
{
Console.WriteLine($"[CRITICAL] Saving record {i}/5");
Thread.Sleep(800);
}
Console.WriteLine("[CRITICAL] All data saved successfully!");
}
static void LoggingOperation()
{
Console.WriteLine("[LOGGER] Starting logging service...");
for (int i = 1; i <= 20; i++)
{
Console.WriteLine($"[LOGGER] Writing log entry {i}");
Thread.Sleep(500);
}
Console.WriteLine("[LOGGER] Logging service completed");
}
static void Main(string[] args)
{
// Foreground thread for critical operation

Thread criticalThread = new Thread(CriticalOperation);
criticalThread.Name = "CriticalThread";
criticalThread.IsBackground = false; // Explicit (default anyway)
// Background thread for logging
Thread loggingThread = new Thread(LoggingOperation);
loggingThread.Name = "LoggingThread";
loggingThread.IsBackground = true;
criticalThread.Start();
loggingThread.Start();
Console.WriteLine("Main thread continues...");
Thread.Sleep(2000);
Console.WriteLine("Main thread ending...");
// Application will wait for criticalThread but not loggingThread
}
}