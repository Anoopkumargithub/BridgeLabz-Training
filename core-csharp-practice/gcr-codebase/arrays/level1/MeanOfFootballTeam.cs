using System;

class MeanOfFootballTeam{
	static void Main(){
		
		double [] Heights = new double[11];
		
		for(int i = 0;i <= Heights.Length;i++){
			Console.WriteLine("Enter a Height:");
			Heights[i] = Convert.ToDouble(ConsoleReadLine());
		}
		double SumOfHeigths = 0;
		
		for(int i = 0;i <= Heights.Length;i++){
			SumOfHeigths += Heights[i];
		}
		
		double MeanOfHeight = SumOfHeigths / 11;
		
		Console.WriteLine($"Mean Height is {MeanOfHeight}.");
		
	}
}