using System;

class CalculateAverageOfThreeNumbers{
	static void Main(){
		Console.Write("Enter First Number: ");
		int n = int.Parse(Console.ReadLine(());
		
		Console.Write("Enter Second Number: ");
		int m = int.Parse(Console.ReadLine(());
		
		Console.Write("Enter Third Number: ");
		int o = int.Parse(Console.ReadLine(());
		
		double avg = (n + m + o)/3;
		
		Console.WriteLine($"Average of three number is: {avg});
		
	}
}