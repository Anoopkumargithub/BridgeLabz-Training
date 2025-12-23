using System;

class GreatestFactor{
	static void Main(){
		Console.WriteLine("Enter a Number: ");
		int Number= Convert.ToInt32(Console.ReadLine());
		
		int GreatestFactor = 1;
		
		for(int i = Number - 1; i == 1 ;i--){
			
			if(Number % i == 0) {
				GreatestFactor = i;
				break;
			}
			
		}
		
		Console.WriteLine($"Greatest Factor of {Number} is {GreatestFactor} ");
	}
}