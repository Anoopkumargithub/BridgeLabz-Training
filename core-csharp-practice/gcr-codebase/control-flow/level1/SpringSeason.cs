using System;

class SpringSeason{
	static void Main(){
		
	Console.WriteLine("Enter a Month: ");
	int Month = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("Enter a Day: ");
	int Day= Convert.ToInt32(Console.ReadLine());
	
	if(Month == 3 && Day >= 20 || Month == 4 || Month == 5 || Month==6 && Day <7= 20){
		Console.WriteLine("It's a Spring Season");
	}else{
		Console.WriteLine("Not a Spring Season");
	}
	}
}