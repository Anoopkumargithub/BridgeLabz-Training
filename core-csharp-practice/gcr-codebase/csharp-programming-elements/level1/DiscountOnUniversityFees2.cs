using System;

class DiscountOnUniversityFees2{
	static void Main(){
		Console.WriteLine("Enter Fees...");
		int Fee = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Discount....");
		int DiscountPercentage = int.Parse(Console.ReadLine());
		double Discount = DiscountPercentage/100.0;
		double DiscountAmount = Fee*Discount;
		double DiscountPrice = Fee - DiscountAmount;
		Console.WriteLine("The Discount amount is INR " + DiscountAmount + " and final discounted fee is INR " + DiscountPrice);
		
	}
}