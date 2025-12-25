using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class SpringSeason
    {
        static string Season(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || ( month == 6 && day  <= 20) )
            {
                return "It's a Spring Season";
            }
            else
            {
                return "Not a Spring Season";
            }
        }
        static void Main()
        {

            Console.WriteLine("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if ((month >= 1 && month <= 12) && (day >= 1 && day <= 31)){ 
                Console.WriteLine($"{Season(month, day)}");
            }
            else
            {
                Console.WriteLine("Enter Correct Month and Day");
            }

        }
    }
}
