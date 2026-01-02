using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_class_object
{
    internal class AreaOfCircle
    {
        private double radius;

        // Constructor
        public AreaOfCircle(double radius)
        {
            this.radius = radius;
        }

        private double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        private double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public void Display()
        {
            double area = CalculateArea();
            double circumference = CalculateCircumference();
            Console.WriteLine($"Area of Circle with Radius {radius} is {area}");
            Console.WriteLine($"Circumference of Circle with Radius {radius} is {circumference}");
        }
    }

    public class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle: ");
            double radius = double.Parse( Console.ReadLine() );

            AreaOfCircle area = new AreaOfCircle(radius);
            area.Display();
        }
    }
}
