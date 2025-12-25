using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level2
{
    internal class LeapYear
    {
        static void FindLeapYear(int year)
        {
            if (year < 1582)
            {
                Console.WriteLine("Enter year greater than 1582");
            }
            else
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("Leapyear");
                }
                else Console.WriteLine("Not a Leapyear");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            FindLeapYear(year);
        }
    }
}
