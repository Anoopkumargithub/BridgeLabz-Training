using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class StudentCanVote
    {
        static void Main()
        {
            Console.WriteLine("Enter the age of Students: ");
            int[] StundetsAge = new int[10];

            for (int i = 0; i < StundetsAge.Length; i++)
            {
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 0)
                {
                    Console.WriteLine("Enter Valid Age");
                    i--;
                }
                else
                {
                    StundetsAge[i] = Age;
                    if (Age >= 18)
                    {
                        Console.WriteLine($"The Student with age {Age} can vote.");

                    }
                    else
                    {
                        Console.WriteLine($"The Student with age {Age} can't vote.");
                    }
                }

            }

        }
    }
}
