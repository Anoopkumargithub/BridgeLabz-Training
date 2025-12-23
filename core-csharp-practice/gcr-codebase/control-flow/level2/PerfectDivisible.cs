using System;

class PerfectDivisible{
	static void Main(){
		Console.WriteLine("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
			
		for(int i = 100; i >= 1; i--){
			
			if(Number % i == 0){
				Console.WriteLine($"Number is Divisible by {i}");
				continue;
			}
		}
		
	}
}