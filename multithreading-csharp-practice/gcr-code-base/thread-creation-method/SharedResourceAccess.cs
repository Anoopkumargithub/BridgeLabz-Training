
using System;
using System.Threading;
class BankAccount
{
private decimal balance = 5000;
public string AccountNumber { get; set; }
public BankAccount(string accountNumber)
{
AccountNumber = accountNumber;
}
public void Withdraw(decimal amount)
{
Console.WriteLine($"[{Thread.CurrentThread.Name}] Attempting to withdraw {amount:C}");
if (balance >= amount)
{
Console.WriteLine($"[{Thread.CurrentThread.Name}] Current balance: {balance:C}");
Thread.Sleep(100); // Simulate processing delay
balance -= amount;
Console.WriteLine($"[{Thread.CurrentThread.Name}] Withdrawal successful. New
balance: {balance:C}");
}
else
{
Console.WriteLine($"[{Thread.CurrentThread.Name}] Insufficient funds!");
}
}
public decimal GetBalance()
{
return balance;
}
}

class Program
{
static void Main(string[] args)
{
BankAccount account = new BankAccount("ACC-001");
// Multiple threads accessing shared resource
Thread customer1 = new Thread(() => account.Withdraw(3000));
Thread customer2 = new Thread(() => account.Withdraw(3000));
customer1.Name = "Customer-1";
customer2.Name = "Customer-2";
customer1.Start();
customer2.Start();
customer1.Join();
customer2.Join();
Console.WriteLine($"\nFinal balance: {account.GetBalance():C}");
Console.WriteLine("Note: This demonstrates race condition - synchronization needed!");
}
}