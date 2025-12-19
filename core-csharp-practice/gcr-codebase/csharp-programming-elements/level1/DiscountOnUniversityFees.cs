using System;

class DiscountOnUniversityFees{
	static void Main(){
		int Fee = 125000;
		int DiscountPercentage = 10;
		double Discount = DiscountPercentage/100.0;
		double DiscountAmount = Fee*Discount;
		double DiscountPrice = Fee - DiscountAmount;
		Console.WriteLine("The Discount amount is INR " + DiscountAmount + " and final discounted fee is INR " + DiscountPrice);
		
	}
}