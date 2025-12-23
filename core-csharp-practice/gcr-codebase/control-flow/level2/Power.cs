using System;

class Power{
	static void Main(){
		Console.WriteLine("Enter a Number: ");
		int Number = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter a Power: ");
		int Power= Convert.ToInt32(Console.ReadLine());
		
		int Result = 1;
		
		for(int i = 1; i<= Power;i++){
			
			Result = Result * Number;
			
		}
		
		Console.WriteLine(Result);
	}
}