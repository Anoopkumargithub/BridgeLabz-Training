using System;

class CalculateGrade{
	static void Main(){
		Console.WriteLine("Enter Physics Marks");
		int Physics = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Chemistry Marks");
		int Chemistry = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Maths Marks");
		int Maths = Convert.ToInt32(Console.ReadLine());
		
		int AverageMarks = ( Physics + Chemistry + Maths ) / 3;
		
		if(AverageMarks >= 80) Console.WriteLine("A");
		else if(AverageMarks >= 70 && AverageMarks <= 79) Console.WriteLine("B");
		else if(AverageMarks >= 60 && AverageMarks <= 69) Console.WriteLine("C");
		else if(AverageMarks >= 50 && AverageMarks <= 59) Console.WriteLine("D");
		else if(AverageMarks >= 40 && AverageMarks <= 49) Console.WriteLine("E");
		else if( AverageMarks <= 39) Console.WriteLine("R");
		
		
	}
}