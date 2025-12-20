using System;

class HeightToFeet{
	static void Main(){
		Console.WriteLine("Enter Height in cm");
		int Height = int.Parse(Console.ReadLine());
		double HeightInInch = Height *2.54;
		double HeightInFeet = HeightInInch * 12;
		Console.WriteLine($"Your Height in cm is {Height} while in feet is {HeightInFeet} and inches is {HeightInInch}");
	}
}