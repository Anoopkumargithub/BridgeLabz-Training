using System;

class AbundantNumber{
	static void Main(){
		Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());
		
		int SumOfDivisor = 0;
		
		for (int i = 1;i < Number; i++){
			if(Number % i == 0 ) SumOfDivisor += i;
		}
		
		if(SumOfDivisor > Number ) Console.WriteLine("Abundant Number");
		else Console.WriteLine("Not a Abundant Number");
		
	}
}