using System;

class SideOfSquare{
	static void Main(){
		Console.WriteLine("Enter Perimeter of square");
		int PerimeterOfSquare = int.Parse(Console.ReadLine());
		
		int SideOfSquare = PerimeterOfSquare/4;
		
		Console.WriteLine($"The length of the side is {SideOfSquare} whose perimeter is {PerimeterOfSquare}");
	}
}