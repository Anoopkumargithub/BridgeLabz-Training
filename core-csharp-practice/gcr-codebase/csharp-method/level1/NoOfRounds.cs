using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class NoOfRounds
    {
        static double Rounds(double perimeter)
        {
            return 5000 / perimeter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides (in m) of triangular park:");
            double Sides1 = Convert.ToDouble(Console.ReadLine());
            double Sides2 = Convert.ToDouble(Console.ReadLine());
            double Sides3 = Convert.ToDouble(Console.ReadLine());
            double perimeter = Sides1 + Sides2 + Sides3;
            

            Console.WriteLine($"The total no. of rounds the athlete will run is {Rounds(perimeter)} to complete 5 km");
        }
    }
}
