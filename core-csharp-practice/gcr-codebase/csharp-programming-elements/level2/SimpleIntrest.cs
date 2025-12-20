using System;

public class SimpleInterest{
	static void Main(){
		
		Console.WriteLine("Enter Principal: ");	
		int Principal = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Rate: ");	
		int Rate = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Time: ");	
		int Time = int.Parse(Console.ReadLine());
		
		double SimpleInterests = (Principal * Rate * Time )/100;
		Console.WriteLine($"The SimpleInterest is {SimpleInterests} for Principal {Principal}, Rate of intrest {Rate} and Time {Time}. ");
	}
}