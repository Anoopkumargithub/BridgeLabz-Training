using System;

class DivideChocolatesAmongChildren{
	static void Main(){
		Console.WriteLine("Enter No. of Chocolates");
		int NumberOfChocolates = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter No. of Children");
		int NumberOfChildren = int.Parse(Console.ReadLine());
		
		int DistributedChocolates = NumberOfChocolates / NumberOfChildren;
		
		int RemainingChocolates = NumberOfChocolates % NumberOfChildren;
		
		Console.WriteLine($"The number of chocolates each child gets is {DistributedChocolates} and the number of remaining chocolates is {RemainingChocolates}");
		
		
		
	}
}