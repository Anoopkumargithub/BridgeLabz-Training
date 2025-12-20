using System;

class NumberOfHandShakes{
	static void Main(){
		Console.Write("Enter No. of Students: ");
		int NumberOfStudents = int.Parse(Console.ReadLine());
		
		int NumberOfPossibleHandShakes = (NumberOfStudents * (NumberOfStudents - 1) ) / 2;
		
		Console.WriteLine($"Number of Possible HandShakes is {NumberOfPossibleHandShakes}");
	}
}