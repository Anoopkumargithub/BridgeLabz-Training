using System;

class NaturalNumber{
	static void Main(){
		
		int Number = int.Parse(Console.ReadLine());
		
		bool Natural = (Number > 0) ? true : false;
		
		if(Natural){
			Console.WriteLine($"The Sum of {Number} Natural Number is {Number * (Number + 1) / 2} ");
		}else{
			Console.WriteLine($"The number {Number} is not a natural number");
	}
}