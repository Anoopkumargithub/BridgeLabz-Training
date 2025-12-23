using System;

class FizzBuzzByWhileLoop{
	static void Mian(){
		
		Console.WriteLine("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
		While(Number > 0){
			
			if(Number % 3) Console.WriteLine("Fizz");
			if(Number % 5) Console.WriteLine("Fizz");
			if(Number % 15) Console.WriteLine("FizzBuzz");
			
			Number--;
		}
	}
}