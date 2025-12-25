using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class NumberOfHandShakes
    {
        static int NumberOfPossibleHandShakes(int numberOfStudents)
        {
            return (numberOfStudents * (numberOfStudents - 1)) / 2;
        }

        static void Main(string[] args) 
        {
            Console.Write("Enter No. of Students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number of Possible HandShakes is {NumberOfPossibleHandShakes(numberOfStudents)}");
        }
    }
}
