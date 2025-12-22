using System;

class PersonCanVote{
	static void Main(){
		
		Console.WriteLine("Enter Age: ");
		
		int Age = int.Parse(Console.ReadLine());
		
		if(Age >= 18 ){
			Console.WriteLine($"The person age is {Age} and can vote.");
		}else{
			Console.WriteLine("The person's age is {Age} and cannot vote.");
		}
	}
}