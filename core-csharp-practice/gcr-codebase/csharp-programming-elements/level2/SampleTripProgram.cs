using System;

class SampleTripProgram{
	static void Main(){
		
		Console.WriteLine("Enter Name: ");
		String Name = Console.ReadLine();
		
		Console.WriteLine("Enter from City: ");
		String FromCity = Console.ReadLine();
		
		Console.WriteLine("Enter Via City: ");
		String ViaCity = Console.ReadLine();
		
		Console.WriteLine("Enter To City: ");
		String ToCity = Console.ReadLine();
		
		Console.WriteLine("Enter From To Via: ");
		String FromToVia = Console.ReadLine();
		
		Console.WriteLine("Enter Via To Final City: ");
		String ViaToFinalCity = Console.ReadLine();
		
		Console.WriteLine("Enter Time Taken: ");
		int TimeTaken = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"The results of the trip are {FromCity}, {ViaCity}, {ToCity}, {FromToVia}, {ViaToFInalCity}");
	}
}