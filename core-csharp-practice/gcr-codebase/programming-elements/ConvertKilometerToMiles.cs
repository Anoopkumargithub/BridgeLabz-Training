using System;

public class ConvertKilometerToMiles{
	static void Main(){
		int km = 5;
		double miles = km *  0.621371;
		
		Console.WriteLine($"{km} KM to Miles: {miles}");
	}
}