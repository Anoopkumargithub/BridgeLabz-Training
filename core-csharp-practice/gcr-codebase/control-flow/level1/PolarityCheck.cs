using System;

class PolarityCheck{
	static void Main(){
		
	Console.WriteLine("Enter a Number: ");
	
	int Number = Convert.ToInt32(Console.ReadLine());
		
	if(Number > 0){
		Console.WriteLine("Positive");
	}
	else if (Number < 0) {
		Console.WriteLine("Negative");
	}
	else {
		Console.WriteLine("Zero");
	}
		
	}
}