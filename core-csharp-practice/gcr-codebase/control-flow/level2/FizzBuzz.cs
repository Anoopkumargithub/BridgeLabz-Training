using System;

class FizzBuzz{
	static void Mian(){
		
		Console.WriteLine("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 0;i < Number; i++){
			
			if(i % 3) Console.WriteLine("Fizz");
			if(i % 5) Console.WriteLine("Fizz");
			if(i % 15) Console.WriteLine("FizzBuzz");
			
		}
	}
}