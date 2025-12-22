using System;

class SumOfNumberPart2{
	static void Main(){
	Console.WriteLine("Enter a Number: ");
	
	int Sum = 0;
	
	while(true){
		int Number = Convert.ToInt32(Console.ReadLine());
		Sum += Number;
		
		if(Number <= 0 ) break;
		}
	Console.WriteLine($"Sum is {Sum}");
	}
}