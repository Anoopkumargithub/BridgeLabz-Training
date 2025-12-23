using System;

class CountDigit{
	static void Main(){
    Console.WriteLine("Enter a number:");
    int Number = Convert.ToInt32(Console.ReadLine());
	int NoOfDigits = 0;
	
	while(Number != 0){
		Number = Number / 10;
		NoOfDigits++;
	}
	Console.WriteLine($"No. Of Digits {NoOfDigits}");
	}
}