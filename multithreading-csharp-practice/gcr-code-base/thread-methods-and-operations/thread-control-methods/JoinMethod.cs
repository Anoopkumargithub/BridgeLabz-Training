/*

Join() - Wait indefinitely
Join(int milliseconds) - Wait with timeout
Returns true if thread terminated, false if timeout

*/


using System;
using System.Threading;
class Program
{
static void Worker(object workerId)
{
Console.WriteLine($"Worker {workerId} started");
Thread.Sleep(2000);
Console.WriteLine($"Worker {workerId} completed");
}
static void Main(string[] args)
{
Thread t1 = new Thread(Worker);
Thread t2 = new Thread(Worker);
Thread t3 = new Thread(Worker);

Console.WriteLine("Starting all workers...");
t1.Start(1);
t2.Start(2);
t3.Start(3);
// Wait for all threads to complete
t1.Join();
Console.WriteLine("Worker 1 joined");
t2.Join(1000); // Wait max 1 second
if (t2.IsAlive)
{
Console.WriteLine("Worker 2 still running after timeout");
}
t3.Join();
Console.WriteLine("All workers completed");
}
}
