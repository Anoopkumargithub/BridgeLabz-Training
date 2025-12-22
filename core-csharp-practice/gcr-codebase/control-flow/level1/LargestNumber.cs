using System;

class LargestNumber{
	static void Main(){
		
	Console.WriteLine("Enter First Number ");
	int FirstNumber = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter Second Number ");
	int SecondNumber = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter Third Number ");
	int ThirdNumber = int.Parse(Console.ReadLine());
	
	bool Largest1 = (SecondNumber < FirstNumber && ThirdNumber < FirstNumber) ? true : false; 
	bool Largest2 = (SecondNumber > FirstNumber && ThirdNumber < SecondNumber) ? true : false; 
	bool Largest3 = (SecondNumber < ThirdNumber && ThirdNumber > FirstNumber) ? true : false; 
	Console.WriteLine($"Is the First number is Largest? {Largest1}");
	Console.WriteLine($"Is the Second number is Largest? {Largest2}");
	Console.WriteLine($"Is the Third number is Largest? {Largest3}");
	}
}