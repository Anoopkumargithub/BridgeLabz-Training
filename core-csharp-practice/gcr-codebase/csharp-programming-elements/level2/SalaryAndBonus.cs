using System;

class SalaryAndBonus{
	static void Main(){
		
		Console.WriteLine("Enter Salary: ");
		int Salary = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter Bonus: ");
		int Bonus = int.Parse(Console.ReadLine());
		
		int TotalSalary = Salary + Bonus;
		
		Console.WriteLine($"The Salary is INR {Salary} and bonus is INR {Bonus}. hence the Total Income is INR {TotalSalary}.");
	}
}