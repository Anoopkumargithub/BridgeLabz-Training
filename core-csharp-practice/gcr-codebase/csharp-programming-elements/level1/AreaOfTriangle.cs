using System;

class AreaOfTriangle{
	static void Main(){
		Console.WriteLine("Enter Base of triangle");
		int Base = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Height of triangle");
		int Height = int.Parse(Console.ReadLine());
		
		double Area = (0.5) * Base * Height;
		
		double AreaInInch = Area *2.54;
		
		Console.WriteLine($"Area in square inches is {AreaInInch} and in square centimeters is {Area}");
		
	}
}