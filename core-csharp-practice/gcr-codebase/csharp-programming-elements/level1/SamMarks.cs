using System;

class SamMarks{
	static void Main(String[] marks){
		int Maths = int.Parse(marks[0]);
		int Physics = int.Parse(marks[1]);
		int Chemistry = int.Parse(marks[2]);
		
		double Average = (Maths + Physics + Chemistry)/3;
		Console.WriteLine($"Sam's average mark in PCM is {Average}");
		// Run -> dotnet run SamMarks.cs 80 90 65
	}
}