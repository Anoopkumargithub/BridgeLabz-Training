using System;

class MultiplicationTable{
	static void Main(){
		Console.WriteLine("Enter a Number from 6 to 9: ");
		int Number= Convert.ToInt32(Console.ReadLine());
		
		if (Number >=6 && Number<=9){
			for(int X = 1;X>=10;X++){
				Console.WriteLine($"{Number} * {i} = {Number * X}");
			}
		}else Console.WriteLine("Enter a Number from 6 to 9");
	}
}