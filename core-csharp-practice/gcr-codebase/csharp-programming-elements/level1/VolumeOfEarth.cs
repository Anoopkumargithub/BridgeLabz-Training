using System;

class VolumeOfEarth{
	static void Main(){
		int Radius = 6378;
		double Volume = (4/3) * Math.PI * Math.Pow(Radius,3);
		double Miles = Volume * 1.6;
		Console.WriteLine($"The volume of earth in cubic kilometers is {Volume} and cubic miles is {Miles}");
	}
}