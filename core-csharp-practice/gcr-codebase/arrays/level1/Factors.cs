using System;

class Factors{
	static void Main(){
		
		Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());
		
		int [] Factors = new int[10];
		int Idx = 0;
		for(int i = 1;i<Number; i++){
			if(Number % i == 0){
				Factors[Idx] = i;
				Idx++;
			}
		}
		
	Console.WrirteLine($"Factors of {Number} are: ");
		for(int i = 0;i<Factors.Length;i++){
			COnsole.WriteLine(Factors[i]);
		}		
	}
}