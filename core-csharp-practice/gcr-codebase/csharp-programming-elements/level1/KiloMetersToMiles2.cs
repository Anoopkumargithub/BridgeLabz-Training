using System;

class KiloMetersToMiles2{
	static void Main(){
		Console.WriteLine("Enter Km");
		double Km = double.Parse(Console.ReadLine());
		double Miles = Km * 1.6;
		Console.WriteLine($"The total Miles is {Miles}mile for the given {Km}km");
	}
}