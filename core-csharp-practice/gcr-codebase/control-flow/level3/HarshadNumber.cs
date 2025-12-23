using System;

class HarshadNumber{
	static void Main(){
	Console.WriteLine("Enter a number:");
	int Number = Convert.ToInt32(Console.ReadLine());
	
	int Sum = 0;
	
	int NumberCopy = Number;
	
	while(NumberCopy != 0){
		int LastDigit = NumberCopy % 10;
		Sum += LastDigit;
		NumberCopy /= 10;
	}
	if(Number % 3 == 0 && Number % Sum == 0){
		Console.WriteLine("Harshad Number");
	}else Console.WriteLine("Not a Harshad Number");
	}
}