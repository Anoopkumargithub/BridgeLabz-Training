using System;

calss Factorial{
	static void Main(){
	Console.WriteLine("Enter a Number: ");
	
	int Number = Convert.ToInt32(Console.ReadLine());
	
	int FactorialOfNumber = 1;
	
	while(Number > 0){
		FactorialOfNumber *= Number;
		Number--;
		}
	Console.WriteLine($"Factorial of {Number} is {FactorialOfNumber}");
	}
}