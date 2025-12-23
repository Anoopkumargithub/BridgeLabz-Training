using System;

class MultiplicationTableFrom6To9{
	static void Main(){
		Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());
		
		int [] MultiplicationResult = new int [4];
		
		int Index = 0;
		for(int i = 6; i <= 9;i++){
			MultiplicationResult[Index] = Number * i;
		} 
		
		for(int i = 1;i <= 10; i++){
			Console.WriteLine($"{Number} * {i} = {MultiplicationResult}");
		}
	}
}