using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class BankSystem
    {
        static bool CheckForUser()
        {
            Bank User = new Bank();
            Console.WriteLine("Enter Account No.");
            int accountNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your PIN");
            int PIN = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (accountNo == User.UserData[i, 0] && PIN == User.UserData[i, 1])
                {
                    return true;
                }
            }
            Console.WriteLine("You Account No. or PIN is Incorrect. Pls Retry Again");
            return CheckForUser();
        }

        static bool CheckForAccountManager()
        {
            Bank Manager = new Bank();
            Console.WriteLine("Enter Manager Id.");
            int ManagerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Password");
            int Password = int.Parse(Console.ReadLine());

            if (ManagerId == Manager.AccountManagerId && Password == Manager.AccountMangerPIN)
            {
                return true;
            }
            Console.WriteLine("You Id or Passwrod is Incorrect. Pls Retry Again");
            return CheckForAccountManager();
        }
        static void ValidateRole()
        {

            Console.WriteLine("Enter 1. For Client OR 2. For Bank Manager");
            int role = int.Parse(Console.ReadLine());
            Bank bank = new Bank();
            if (role == 1)
            {
                // check Id Passward of user
                bool validate = CheckForUser();
                if (validate)
                {
                    User currentUser = new User();
                    Console.WriteLine($"Welcome {currentUser.Name} to {bank.BankName}");
                    Console.WriteLine("----Bank Menu----");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdarwal");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                }
            }
            else
            {
                // check Id Password of Bank Manager
                bool validate = CheckForAccountManager();
                if ((validate))
                {
                    Manager currentManager = new Manager();
                    Console.WriteLine($"Welcome {currentManager.Name} to {bank.BankName}");
                    Console.WriteLine("----Bank Manager Menu----");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdarwal");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                }
            }
        }


        public static void Main(string[] args)
        {
            // validate function by role
            ValidateRole();
        }
    }

    public class Bank
    {
        // public fields
        public string BankName;
        public string[] BranchName;
        public string[] IFSCCode;

        // fix fields
        public readonly int MinBalance = 2000; // minimum balance 2000
        public readonly int MaxTransaction = 100000; // max transaction 1 Lakh only per day
        public readonly int MaxNoOfTransaction = 5;  // max. no. of transaction per day    

        // Acount Manager Details 
        public readonly int AccountManagerId = 1234; // Account Manager  Login Id
        public readonly int AccountMangerPIN = 4321; // Account Manager Login PIN

        // user Account Details (Account No., PIN, Current Balance)

        public int[,] UserData = new int[10, 3]
                            {
                                { 1001, 1111, 0 },
                                { 1002, 2222, 0 },
                                { 1003, 3333, 0 },
                                { 1004, 4444, 0 },
                                { 1005, 5555, 0 },
                                { 1006, 6666, 0 },
                                { 1007, 7777, 0 },
                                { 1008, 8888, 0 },
                                { 1009, 9999, 0 },
                                { 1010, 1234, 0 }
                            };


    }

    public class User
    {
        public string Name;
        public string BankName;
    }

    public class Manager
    {
        public string Name;
    }


}
