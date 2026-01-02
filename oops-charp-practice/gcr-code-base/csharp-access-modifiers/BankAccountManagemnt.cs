using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_access_modifiers
{
    internal class BankAccount
    {
        // public variable
        public int accountNumber;

        // protected variable
        protected string accountHolder;

        // private variable
        private double balance;

        // Constructor
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Public method to get balance
        public double GetBalance()
        {
            return balance;
        }

        // Public method to update balance
        public void SetBalance(double amount)
        {
            balance = amount;
        }

        // Instance Method
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Balance: INR " + balance);
        }
    }

    // Subclass
    internal class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            this.interestRate = interestRate;
        }

        // Accessing public and protected members
        public void DisplaySavingsAccountDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);   // public
            Console.WriteLine("Account Holder: " + accountHolder);   // protected
            Console.WriteLine("Interest Rate: " + interestRate + "%");
        }
    }

    class BankManagement
    {
        public static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(123456, "Jhon Carter", 50000);

            Console.WriteLine("Bank Account Details:");
            acc1.DisplayAccountDetails();
            Console.WriteLine();

            // Modify balance using public methods
            acc1.SetBalance(65000);
            Console.WriteLine("Updated Balance: INR " + acc1.GetBalance());
            Console.WriteLine();

            SavingsAccount sa1 =
                new SavingsAccount(789012, "Mike Pascal", 80000, 4.5);

            Console.WriteLine("Savings Account Details:");
            sa1.DisplaySavingsAccountDetails();
        }
    }
}