using System;

class DIvisibleBy5{
	static void Main(){
		
		// Take input by TryParse
		Console.WriteLine("Enter a Number");
		string Input = Console.ReadLine();
		
		if(int.TryParse(Input, out int Number)){
			Console.WriteLine($"You entered : {Number}");
		}else{
			Console.WriteLine("You enter invalid number");
		}
		
		Console.WriteLine($"Number is divisible by 5 {Number % 5}");
		
	}
}