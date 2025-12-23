using System;

class YoungestFriend{
	static void Main(){
		Console.WriteLine("Enter Amar Age and height: ");
		int AmarAge = Convert.ToInt32(Console.ReadLine());
		int AmarHeight = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter Akbar Age: ");
		int AkbarAge = Convert.ToInt32(Console.ReadLine());
		int AkbarHeight = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter Anthony Age : ");
		int AnthonyAge = Convert.ToInt32(Console.ReadLine());
		int AnthonyHeight = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Smallest Age: ");
		if(AmarAge < AkbarAge && AmarAge < AnthonyAge) Console.WriteLine("Amar ");
		if(AmarAge > AkbarAge && AkbarAge < AnthonyAge) Console.WriteLine("Akbar ");
		else Console.WriteLine("Anthony ");
		
		Console.WriteLine("Largest Height: ");
		if(AmarHeight > AkbarHeight && AmarHeight > AnthonyHeight ) Console.WriteLine("Amar ");
		if(AmarHeight< AkbarHeight && AkbarHeight > AnthonyHeight ) Console.WriteLine("Akbar ");
		else Console.WriteLine("Anthony ");
		
	}
}