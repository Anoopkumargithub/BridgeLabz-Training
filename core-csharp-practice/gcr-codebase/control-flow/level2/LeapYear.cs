using System;

class LeapYear{
	static void Main(){
	Console.WriteLine("Enter Year: ");
	int Year = Convert.ToInt32(Console.ReadLine());
	if(LeapYear < 1582){
		Console.WriteLine("Enter Year greater than 1582");
	}else{
		if((LeapYear % 4 == 0 && LeapYear % 100 != 0) || LeapYear % 400 == 0){
			Console.WriteLine("LeapYear");
		}else Console.WriteLine("Not a LeapYear");
	}
	}
}