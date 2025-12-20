using System;

class QuotientAndRemainder{
	static void Main(){
		Console.Write("Enter First Number: ");
		int FirstNumber = int.Parse(Console.ReadLine());
		
		Console.Write("Enter Second Number: ");
		int SecondNumber = int.Parse(Console.ReadLine());
		
		int Quotient = FirstNumber / SecondNumber;
		int Remainder = FirstNumber % SecondNumber;
		
		Console.WriteLine($"The Quotient is {Quotient} and Remainder is {Remainder} of two numbers {FirstNumber} and {SecondNumber}.");
	}
}