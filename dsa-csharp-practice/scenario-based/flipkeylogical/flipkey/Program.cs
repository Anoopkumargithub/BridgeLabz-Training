using System;
namespace FlipKeyLogical;

public class Program
{
    public static  void Main(string[] args)
    {
        Console.WriteLine("-----Flip Key-----");
        Console.WriteLine();
        Console.WriteLine("Enter You Password");
        string password = Console.ReadLine();

        FlipKeyUtility utility = new FlipKeyUtility();
        string processedPassword = utility.CleanseAndInvert(password);

        if(processedPassword.Equals(""))
        {
            Console.WriteLine("Invalid Password!!");
        }else
        {
            Console.WriteLine($"Generated Key: {processedPassword}");
        }
    }
}
