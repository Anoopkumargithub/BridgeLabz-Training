using System;

class OddAndEven{
	static void Main(){
	Console.WriteLine("Enter a Number: ");
	
	int Number = Convert.ToInt32(Console.ReadLine());
	
	if (Number % 2 == 0){
		Console.WriteLine("Even");
		}
	else  Console.WriteLine("Odd");
	}
}