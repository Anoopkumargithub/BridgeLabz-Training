using System;

class CountDownUsingLoop{
	static void Main(){
	Console.WriteLine("Enter a Number: ");
	
	int Number = Convert.ToInt32(Console.ReadLine());
	
	for(int i = Number; i > 0; i--){
		Console.WriteLine(i);
		}
	}
}