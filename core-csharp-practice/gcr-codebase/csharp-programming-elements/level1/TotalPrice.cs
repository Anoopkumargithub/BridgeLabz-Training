using System;

class TotalPrice{
	static void Main(){
		Console.Write("Enter Unit Price: ");
		int UnitPrice = int.Parse(Console.ReadLine());
		
		Console.Write("Enter Quantity: ");
		int Quantity = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"The total purchase price is INR {UnitPrice * Quantity} if the quantity {Quantity} and unit price is INR {UnitPrice}");
		
	}
}