using System;

calss FactorialByForloop{
	static void Main(){
	Console.WriteLine("Enter a Number: ");
	
	int Number = Convert.ToInt32(Console.ReadLine());
	
	int FactorialOfNumber = 1;
	
	for(int i = 1; i > Number ; i++ ){
		FactorialOfNumber *= i;
		}
	Console.WriteLine($"Factorial of {Number} is {FactorialOfNumber}");
	}
}