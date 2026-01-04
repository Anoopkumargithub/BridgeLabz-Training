using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class BankAccount
    {
        // Static Variable
        public static string bankName;
        private static int totalAccounts = 0;

        // Instance Variables
        public string AccountHolderName;
        public readonly int AccountNumber;
        private double balance;

        public BankAccount(string AccountHolderName, int AccountNumber, double balance)
        {
            // using this keyword
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            this.balance = balance;

            totalAccounts++;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Bank Name          : " + bankName);
            Console.WriteLine("Account Holder     : " + AccountHolderName);
            Console.WriteLine("Account Number     : " + AccountNumber);
            Console.WriteLine("Balance            : INR " + balance);
        }

        // Static Method
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts Created : " + totalAccounts);
        }
    }

    class BankSystem
    {
        public static void Main(string[] args)
        {
            BankAccount.bankName = "Lena Dena Bank";

            BankAccount acc1 = new BankAccount("Atma Ram", 10101, 50000);
            BankAccount acc2 = new BankAccount("Popat Lal", 10102, 5000);

            Console.WriteLine("Account 1 Details:");
            if (acc1 is BankAccount)
            {
                acc1.DisplayAccountDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Account 2 Details:");
            if (acc2 is BankAccount)
            {
                acc2.DisplayAccountDetails();
            }
            Console.WriteLine();

            BankAccount.GetTotalAccounts();
        }
    }
}
