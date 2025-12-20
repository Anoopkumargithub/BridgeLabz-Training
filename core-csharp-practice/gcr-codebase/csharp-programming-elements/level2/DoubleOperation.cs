using System;

class DoubleOperation{
	static void Main(String[] args){
		Console.WriteLine("Enter First Number: ");
		double FirstNumber = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Second Number: ");
		double SecondNumber = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Third Number: ");
		double ThirdNumber = double.Parse(Console.ReadLine());
		
		Console.WriteLine($"The results of double operations are {FirstNumber + SecondNumber * ThirdNumber}, {FirstNumber * SecondNumber + ThirdNumber}, { ThirdNumber + FirstNumber / SecondNumber}, and {FirstNumber % SecondNumber + ThirdNumber}");
	
	}
}