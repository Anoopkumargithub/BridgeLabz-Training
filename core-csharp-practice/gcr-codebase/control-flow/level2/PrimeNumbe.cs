using System;

class PrimeNumber{
	static void Main(){
		Console.WriteLine("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
		if(Number <= 1) Console.WriteLine("Not a Prime Number");
		if(Number == 2) Console.WriteLine("Prime Number");
		if(Number % 2 == 0 ) Console.WriteLine("Not a Prime Number");
		
		for(int X = 3; X * X <= Number; X += 2){
			if(Number % X == 0) Console.WriteLine("Not a Prime Number");
			
			Console.WriteLine("Prime Number");
		}
			
	}
}