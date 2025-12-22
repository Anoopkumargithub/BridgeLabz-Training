using System;

class SumOfNaturalNumberByForLoop{
	static void Main(){
		
		int Number = int.Parse(Console.ReadLine());
		
		bool Natural = (Number > 0) ? true : false;
		
		int Sum = 0;
		
		while(int i = 0;i<number; i ++){
			Sum += i;
		}
		
		int CalculatedSum = Number * (Number + 1) / 2;
		
		if(CalculatedSum == Sum){
			Console.WriteLine($"The Sum of {Number} Natural Number is {Number * (Number + 1) / 2} and CalculatedSum and WhileLoop Sum are same ");
		}else if (CalculatedSum != Sum){
			Console.WriteLine($"The Sum of {Number} Natural Number is {Number * (Number + 1) / 2} and CalculatedSum {CalculatedSum}  and WhileLoop Sum {Sum} are not same ");
		}
		else{
			Console.WriteLine($"The number {Number} is not a natural number");
	}
}