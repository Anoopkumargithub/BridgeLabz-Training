using System;

public class VolumeOfCylinder{
	
	static void Main(){
		int radius = 2;
		int height = 5;
		
		double volume = Math.PI*Math.Pow(radius,2)*height;
		Console.WriteLine($"Volume of Cylinder: {volume}");
	}
}