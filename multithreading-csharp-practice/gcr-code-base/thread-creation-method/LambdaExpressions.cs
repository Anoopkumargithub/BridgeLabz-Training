using System;
using System.Threading;
class Program
{
static void Main(string[] args)
{
int multiplier = 2;
// Lambda expression capturing local variable
Thread thread = new Thread(() =>
{
for (int i = 1; i <= 5; i++)
{
Console.WriteLine($"Value: {i * multiplier}");
Thread.Sleep(300);
}
});
thread.Name = "LambdaThread";
thread.Start();
thread.Join();
}
}