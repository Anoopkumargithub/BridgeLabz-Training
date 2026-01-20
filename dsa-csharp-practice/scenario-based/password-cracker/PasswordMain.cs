using System;

internal class PasswordMain
{
    
    Random random = new Random();
    static void Main()
    {
         IChecker checker = new CheckerImpl();
        //Generate Random Password
        string Password = checker.GeneratePassword();
        Console.WriteLine("Generated Password: ");
        Console.Write(Password);
        System.Console.WriteLine();
        Password pwdObj = new Password(Password);
        
        DateTime start = DateTime.Now;
        System.Console.WriteLine("Cracking Password...");
        // create passwrod cracker 
        if(checker.Cracker(pwdObj, "", 0))
        {
            System.Console.WriteLine("Password Cracked Successfully");
        }
        DateTime end = DateTime.Now;
        Console.WriteLine("Time taken to crack the password: " + (end - start).TotalSeconds + " seconds");
    }
}