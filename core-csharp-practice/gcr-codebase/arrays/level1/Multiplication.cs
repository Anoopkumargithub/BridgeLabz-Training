using System;

class Multiplication{
	static void Main(){
		Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());
		
		int[] Table = new int [10];
		
		for(int i = 1;i<= 10;i++){
			Table[i] = Number * i;
		}
		
		for(int i = 1;i<= 10 ;i++){
		Console.WriteLine($"{Number} * {i} = {Table[i]}");
		}
		
	}
}