using System;

class Calculator{
	static void Main(){
		Console.WriteLine("Enter first number");
		float FirstNumber = float.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter second number");
		float SecondNumber = float.Parse(Console.ReadLine());
		
		float Addition = FirstNumber + SecondNumber;
		float Subtraction = FirstNumber - SecondNumber;
		float Multiplication = FirstNumber * SecondNumber;
		float Division = FirstNumber / SecondNumber;
		
		Console.WriteLine($" The addition, subtraction, multiplication and division value of 2 numbers {Addition}, {Subtraction}, {Multiplication}, and {Division}");		
	}
}