using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level1
{
    internal class TrigonometryFunctions
    {
        static double[] CalculateTrigonometryFunction(double angle) 
        {
            double radian = angle * Math.PI / 180;

            double sin = Math.Sin(radian);
            double cos = Math.Cos(radian);
            double tan = Math.Tan(radian);

            return new double[] { sin, cos, tan };
        }
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter angle in degree");

            double angle = Convert.ToDouble(Console.ReadLine());

            double[] result = CalculateTrigonometryFunction(angle);

            Console.WriteLine($"Sin: {result[0]}");
            Console.WriteLine($"Cos: {result[1]}");
            Console.WriteLine($"Tan: {result[2]}");
        }
    }
}
