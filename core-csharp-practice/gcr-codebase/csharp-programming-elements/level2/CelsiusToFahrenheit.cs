using System;

class CelsiusToFahrenheit{
	static void Main()
	{
		Console.WriteLine("Enter Temperature in Celsius");
		int Celsius = int.Parse(Console.ReadLine());
		double Fahrenheit = (Celsius * (9/5)) + 32;
		
		Console.WriteLine($"Celsius to Fahrenheit: {Fahrenheit}");
	}
}