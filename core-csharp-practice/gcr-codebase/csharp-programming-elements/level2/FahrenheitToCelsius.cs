using System;

class FahrenheitToCelsius{
	static void Main()
	{
		Console.WriteLine("Enter Temperature in Fahrenheit");
		int Fahrenheit = int.Parse(Console.ReadLine());
		double Celsius = (Fahrenheit - 32) * (5/9);
		
		Console.WriteLine($"Fahrenheit to Celsius: {Celsius}");
	}
}