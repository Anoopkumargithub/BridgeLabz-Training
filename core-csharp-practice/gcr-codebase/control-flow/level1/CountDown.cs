using System;

class CountDown{
	static void Main(){
	Console.WriteLine("Enter a Number: ");
	
	int Number = Convert.ToInt32(Console.ReadLine());
	
	while(Number > 0){
		Console.WriteLine(Number);
		Number--;
		}
	}
}