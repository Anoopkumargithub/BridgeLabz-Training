using System;

class OddEvenArray{
	static void Main(){
		Console.WriteLine("Enter a number:");
        int Number = Convert.ToInt32(Console.ReadLine());
		
		int [] EvenNumbers = new int [Number/2];
		int [] OddNumbers = new int [Number/2];
		int EvenIdx = 0;
		int OddIdx = 0;
		for(int i = 0;i<= Number;i++){
			if(i % 2 == 0) {
				EvenNumbers[EvenIdx] = i;
				EvenIdx++;
			}else{
				OddNumbers[OddIdx] = i;
				OddIdx++;
			}
		}
		
		for(int i = 0;i<EvenNumbers;i++){
			Console.WriteLine(EvenNumbers[i];);
		}
		for(int i = 0;i<OddNumbers;i++){
			Console.WriteLine(OddNumbers[i];);
		}
	}
}