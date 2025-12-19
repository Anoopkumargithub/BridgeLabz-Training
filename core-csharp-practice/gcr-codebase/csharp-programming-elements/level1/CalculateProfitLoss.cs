using System;

class CalculateProfitLoss{
	
	static void Main(String[] args){
		int CostPrice = 129;
		int SellingPrice = 191;
		int Profit = SellingPrice - CostPrice;
		float ProfitPercentage = ((float)Profit * 100 ) / SellingPrice;
		
		Console.WriteLine("The Cost Price is INR "+ CostPrice + " and SellingPrice is INR " + SellingPrice);
		Console.WriteLine("The Profit is INR "+ Profit + " and ProfitPercentage is " + ProfitPercentage);
	}
}