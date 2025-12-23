using System;

class SumOfNumber{
	static void Main(){
		double [] Array = new double [10];
		
		int Idx = 0;

		while(true){
			Console.WriteLine("Enter a number:");
			double Number = Convert.ToDouble(Console.ReadLine());
			
			if(Number <= 0 || Idx > 10 ) break;
			
			Array[Idx] = Number;
			Idx++;
			
		}
		
		double Sum = 0;
		
		for(int i = 0;i<10;i++{
			sum += Array[i];
		}
		
		Console.WriteLine($"Sum of All Numbers {Sum}");
	}
}