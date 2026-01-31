using System;

namespace BankAccount;

public class BankAccount
{
    public decimal Balance { get; set; }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    // deposite method
    public void Deposit(decimal amount)
    {
        if(amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative");
        }
        Balance += amount;
    }

    // withdraw method

    public void Withdraw(decimal amount)
    {
        if(amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
    }


    // Main Mehthod

    public static void Main(String[] args)
    {
        BankAccount account =  new BankAccount(1000);
        Console.WriteLine("Initial Balance: " + account.Balance);

        // Deposit 500
        Console.WriteLine("Depositing 500...");
        account.Deposit(500);

        // Withdraw 200
        Console.WriteLine("Withdrawing 200...");
        account.Withdraw(200);

        Console.WriteLine("Final Balance: " + account.Balance);
    }

}
