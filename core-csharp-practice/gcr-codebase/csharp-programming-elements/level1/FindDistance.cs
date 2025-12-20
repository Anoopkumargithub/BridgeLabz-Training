using System;

class FindDistance{
	static void Main(){
		Console.WriteLine("Enter distance in feet");
		int DistanceInFeet = int.Parse(Console.ReadLine());
		
		int DistanceInYard = DistanceInFeet * 3;
		int DistanceInMile = DistanceInYard * 1760;
		
		Console.WriteLine($"Distance in Yard is {DistanceInYard} in mile is {DistanceInMile}");
		
	}
}