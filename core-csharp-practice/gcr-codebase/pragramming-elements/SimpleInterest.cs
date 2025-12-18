using System;

public class SimpleInterest{
	static void Main(){
		int p = 1000;
		int r = 10;
		int t = 2;
		double si = (p*r*t)/100;
		Console.WriteLine($"SI {si}");
	}
}