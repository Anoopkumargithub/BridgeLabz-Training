/*

Important Notes:

Can only call Start() once per thread instance
Calling Start() twice throws ThreadStateException
Creates a new thread and begins execution

*/



using System;
using System.Threading;
class Program
{
static void Task1()
{
Console.WriteLine("Task 1 executing");
}
static void Task2(object parameter)
{
Console.WriteLine($"Task 2 executing with: {parameter}");
}
static void Main(string[] args)
{
// Start without parameters
Thread t1 = new Thread(Task1);
t1.Start();
// Start with parameters
Thread t2 = new Thread(Task2);
t2.Start("Parameter Value");
t1.Join();
t2.Join();
}
}
