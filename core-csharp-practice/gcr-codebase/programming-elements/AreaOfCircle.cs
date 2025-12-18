using System;

class AreaOfCircle{
	
	static void Main()
	{
		Console.Write("Enter Radius of Circle: ");
		int radius = int.Parse(Console.ReadLine());
		
		double area = 3.14 * radius * radius;
		
		Console.WriteLine($"Area of Circle: {area}");
	}
}