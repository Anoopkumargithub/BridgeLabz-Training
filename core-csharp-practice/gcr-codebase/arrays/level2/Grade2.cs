using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Grade2
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number of Students: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            
            int[,] Marks = new int[Number,4];
            int[] Percentage = new int[Number];
            char[] Grades = new char[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine($"Enter marks of Student {i}");
                Console.WriteLine();
                Console.WriteLine("in Physics");
                Marks[i,0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("in Chemistry");
                Marks[i,1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("in Maths");
                Marks[i,2] = Convert.ToInt32(Console.ReadLine());

                Marks[i,3] = (Marks[i,0] + Marks[i,1] + Marks[i,2]);

                Percentage[i] = (Marks[i,3] * 100) / 300;

                if (Percentage[i] >= 80) Grades[i] = 'A';
                else if (Percentage[i] >= 70 && Percentage[i] <= 79) Grades[i] = 'B';
                else if (Percentage[i] >= 60 && Percentage[i] <= 69) Grades[i] = 'C';
                else if (Percentage[i] >= 50 && Percentage[i] <= 59) Grades[i] = 'D';
                else if (Percentage[i] >= 40 && Percentage[i] <= 49) Grades[i] = 'E';
                else Grades[i] = 'R';

            }

            // display Marks Percentages and Grades

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine($"Marks is {Marks[i,3]} and percentage is {Percentage[i]}% and got a Grade {Grades[i]}");
            }

        }
    }
}
