using System;

class IntOperation{
	static void Main(String[] args){
		Console.WriteLine("Enter First Number: ");
		int FirstNumber = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Second Number: ");
		int SecondNumber = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Third Number: ");
		int ThirdNumber = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"The results of int operations are {FirstNumber + SecondNumber * ThirdNumber}, {FirstNumber * SecondNumber + ThirdNumber}, { ThirdNumber + FirstNumber / SecondNumber}, and {FirstNumber % SecondNumber + ThirdNumber}");
	
	}
}