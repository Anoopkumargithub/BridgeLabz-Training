using System;
using System.Threading;
class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(500); // Pause for 500 milliseconds
        }
    }
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(new ThreadStart(PrintNumbers));
        Thread thread2 = new Thread(new ThreadStart(PrintNumbers));

        // Set thread names
        thread1.Name = "Thread-1";
        thread2.Name = "Thread-2";
        // Start threads
        thread1.Start();
        thread2.Start();
        // Wait for threads to complete
        thread1.Join();
        thread2.Join();
        Console.WriteLine("Both threads completed!");
    }
}