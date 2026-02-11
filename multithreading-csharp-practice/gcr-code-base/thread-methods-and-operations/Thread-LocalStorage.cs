using System;
using System.Threading;
class Program
{
[ThreadStatic]
private static int threadStaticValue;
private static ThreadLocal<int> threadLocalValue = new ThreadLocal<int>();
static void ThreadWork(object id)
{
// Each thread has its own copy
threadStaticValue = (int)id * 100;
threadLocalValue.Value = (int)id * 200;
Thread.Sleep(100);
Console.WriteLine($"Thread {id}:");
Console.WriteLine($" ThreadStatic: {threadStaticValue}");

Console.WriteLine($" ThreadLocal: {threadLocalValue.Value}");
}
static void Main(string[] args)
{
Thread t1 = new Thread(ThreadWork);
Thread t2 = new Thread(ThreadWork);
Thread t3 = new Thread(ThreadWork);
t1.Start(1);
t2.Start(2);
t3.Start(3);
t1.Join();
t2.Join();
t3.Join();
}
}

