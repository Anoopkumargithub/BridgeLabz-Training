using System;

class FindBonus{
	static void Main(){
		Console.WriteLine("Enter your year of service: ");
		
		int YearOfService = Convert.ToInt32(Console.ReadLine());
		int Salary = Convert.ToInt32(Console.ReadLine());
		
		if (YearOfService > 5){
			Salary = Salary + Salary * 0.5;
			Console.WriteLine($" Bonus Ammount is {Salary*0.5} and Total salary is {Salary}");
		}
		
	}
}