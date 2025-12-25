using System;

class LeapYear{
	static void Main(){
	Console.WriteLine("Enter Year: ");
	int Year = Convert.ToInt32(Console.ReadLine());
	if(Year < 1582){
		Console.WriteLine("Enter Year greater than 1582");
	}else{
		if((Year % 4 == 0 && Year % 100 != 0) || 	Year % 400 == 0){
			Console.WriteLine("LeapYear");
		}else Console.WriteLine("Not a LeapYear");
	}
	}
}