using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction.level1
{
    internal class DateArithmetic
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a date (yyyy-MM-dd): ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            DateTime resultDate = inputDate
                                    .AddDays(7)
                                    .AddMonths(1)
                                    .AddYears(2)
                                    .AddDays(-21); 

            Console.WriteLine("\nOriginal Date : " + inputDate.ToShortDateString());
            Console.WriteLine("Final Date    : " + resultDate.ToShortDateString());
        }
    }
}
