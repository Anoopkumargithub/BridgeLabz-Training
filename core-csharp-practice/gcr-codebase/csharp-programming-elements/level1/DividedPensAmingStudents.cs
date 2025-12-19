using System;

class DividedPensAmingStudents{
	static void Main(){
		int NumberOfPens = 14;
		int NumberOfStudent = 3;
		
		int DistributedPen = NumberOfPens / NumberOfStudent;
		
		int NonDistributedPen = NumberOfPens % NumberOfStudent;
		
		Console.WriteLine("The Pen Per Student is " + DistributedPen + " and the remaining pen not distributeds is " + NonDistributedPen);
	}
}