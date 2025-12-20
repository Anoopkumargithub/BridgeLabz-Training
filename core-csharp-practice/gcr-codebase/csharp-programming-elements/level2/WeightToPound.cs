using System;

class WeightToPound{
	static void Main(){
		Console.WriteLine("Enter Weight (in pounds): ");	
		int Weight = int.Parse(Console.ReadLine());
		
		Console.WriteLine($" The weight of the person in pounds is {Weight} and in kg is {Weight * 2.2}");		
	}
}