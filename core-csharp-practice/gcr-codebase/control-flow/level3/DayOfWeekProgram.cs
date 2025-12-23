using System;

class DayOfWeekProgram{
	static void Main(){
		
		Console.WriteLine("Enter a Year:");
        int Year = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter a Month:");
        int Month = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter a Day:");
        int Day = Convert.ToInt32(Console.ReadLine());
		
		DateTime Date = new DateTime(Year, Month, Day);
		
		int WeekDay = (int) Date.DayOfWeek;
		
		Console.WriteLine(WeekDay);
		Console.WriteLine(Date.DayOfWeek);
	}
}