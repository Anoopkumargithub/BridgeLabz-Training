using System;
using System.Threading;
class Counter
{
private string counterName;
private int maxCount;
public Counter(string name, int max)
{
counterName = name;
maxCount = max;
}
public void Count()
{
for (int i = 1; i <= maxCount; i++)
{
Console.WriteLine($"{counterName} [{Thread.CurrentThread.Name}]: {i}");
Thread.Sleep(300);
}
Console.WriteLine($"{counterName} completed!");
}
}
class Program
{
static void Main(string[] args)
{
Counter counter1 = new Counter("Counter-A", 5);
Counter counter2 = new Counter("Counter-B", 5);
Thread t1 = new Thread(new ThreadStart(counter1.Count));
Thread t2 = new Thread(new ThreadStart(counter2.Count));
t1.Name = "T1";
t2.Name = "T2";

t1.Start();
t2.Start();
t1.Join();
t2.Join();
}
}