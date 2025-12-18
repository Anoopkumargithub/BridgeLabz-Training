using System;

class CelsiusToFahrenheit{
	static void Main()
	{
		
		int celsius = 32;
		double fahrenheit = (celsius * (9/5)) + 32;
		
		Console.WriteLine($"Celsius to Fahrenheit: {fahrenheit}");
	}
}