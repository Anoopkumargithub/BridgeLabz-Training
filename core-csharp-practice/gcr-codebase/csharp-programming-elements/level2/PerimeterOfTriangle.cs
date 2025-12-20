using System;

class PerimeterOfTriangle{
	static void Main(){
		Console.WriteLine("Enter sides of triangular park:");
		int Sides1 = int.Parse(Console.ReadLine());
		int Sides2 = int.Parse(Console.ReadLine());
		int Sides3 = int.Parse(Console.ReadLine());
		int Perimeter = Sides1 + Sides2 + Sides3;
		int Rounds = 5/Perimeter;
		
		Console.WriteLine($"The total no. of rounds the athlete will run is {Rounds} to complete 5 km");
		
	}
}
