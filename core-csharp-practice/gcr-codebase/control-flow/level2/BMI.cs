using System;

class BMI{
	static void Main(){
		Console.WriteLine("Enter weight (in Kg): ");
		double Weight = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter height (in cm): ");
		double Height = Convert.ToDouble(Console.ReadLine());
		
		// cm to m conversion
		Height = Height * 0.01;
		
		double BMI = Weight / (Height * Height)
		
		if(BMI <= 18.4) Console.WriteLine("UnderWeight");
		if(BMI > 18.4 && BMI < 24.9) Console.WriteLine("Normal");
		if(BMI > 25.0 && BMI < 39.9) Console.WriteLine("Overweight");
		if(BMI >= 40.0 ) Console.WriteLine("Obese");
		
	}
}