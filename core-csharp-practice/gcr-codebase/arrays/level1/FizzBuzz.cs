using System;

class FizzBuzz{
	static void Main(){
		
		Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());
		
		string[] Arrays = new string[Number];
		
		int Idx = 0;
		for(int i = 0;i<Number;i++){
			
			if(i % 3 == 0){
				Arrays[Idx] = "Fizz";
			}else if(i % 5 == 0){
				Arrays[Idx] = "Buzz";
			}else if(i % 15 == 0){
				Arrays[Idx] = "FizzBuzz";
			}else continue;			
			
			Idx++;
		}
		
		for(int i = 0;i<Idx;i++){
			Console.WriteLine(Arrays[i]);
		}
	}
}