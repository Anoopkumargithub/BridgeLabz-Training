using System;
using System.Threading;
class Program
{
static void PrintMessage(object message)
{
string msg = message.ToString();
for (int i = 1; i <= 3; i++)
{
Console.WriteLine($"{Thread.CurrentThread.Name}: {msg} - Count: {i}");
Thread.Sleep(400);
}
}
static void Main(string[] args)
{
Thread thread1 = new Thread(new ParameterizedThreadStart(PrintMessage));
Thread thread2 = new Thread(new ParameterizedThreadStart(PrintMessage));
thread1.Name = "Worker-1";
thread2.Name = "Worker-2";

thread1.Start("Hello");
thread2.Start("Welcome");
thread1.Join();
thread2.Join();
Console.WriteLine("Execution completed!");
}
}