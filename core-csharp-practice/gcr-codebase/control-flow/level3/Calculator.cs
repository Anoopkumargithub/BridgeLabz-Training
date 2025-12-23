using System;

class Calculator{
	static void Main(){
		Console.WriteLine("Enter a First number:");
        double FirstNumber = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter a Second number:");
        double SecondNumber = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter operation ('+', '-', '*', '/')");
        char Operation = Convert.ToChar(Console.ReadLine());
		
		switch(Operation){
			case '+':
				Console.WriteLine($"Resule Is {FirstNumber + SecondNumber}");
			case '-':
				Console.WriteLine($"Resule Is {FirstNumber + SecondNumber}");
			case '*':
				Console.WriteLine($"Resule Is {FirstNumber + SecondNumber}");
			case '/':
				Console.WriteLine($"Resule Is {FirstNumber + SecondNumber}");
			default:
				Console.WriteLine("Invalid Operation");
		}
		
		
		
	}
}