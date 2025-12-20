using System;

class SwapTwoNumber{
	static void Main(){
		Console.WriteLine("Enter First Number: ");
		int FirstNumber = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Second Number: ");
		int SecondNumber = int.Parse(Console.ReadLine());
		
		int TemperaryNumber = FirstNumber;
		FirstNumber = SecondNumber;
		SecondNumber = TemperaryNumber;
		
		Console.WriteLine($"The swapped numbers are {FirstNumber} and {SecondNumber}");
	}
}