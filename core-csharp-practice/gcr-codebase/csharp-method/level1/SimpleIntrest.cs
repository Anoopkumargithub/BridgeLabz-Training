using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.methods.level1
{
    internal class SimpleIntrest
    {

        public static double CalculateSimpleIntrest(int principal, int rate, int time) 
        {
            return  (principal * rate * time) / 100; ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal: ");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Time: ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The SimpleInterest is {CalculateSimpleIntrest(principal, rate, time)} for Principal {principal}, Rate of intrest {rate} and Time {time}. ");



        }
    }
}
