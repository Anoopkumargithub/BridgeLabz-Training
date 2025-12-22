using System;

class SmallestNumber{
	static void Main(){
	
	Console.WriteLine("Enter First Number ");
	int FirstNumber = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter Second Number ");
	int SecondNumber = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter Third Number ");
	int ThirdNumber = int.Parse(Console.ReadLine());
	
	bool Small = (SecondNumber > FirstNumber && ThirdNumber > FirstNumber) ? true : false; 
	Console.WriteLine($"Is the First number is smallest? {Small}");
	}
}