using System;

class MultiDimensionalArray{
	
	static void Main(){
		
		Console.WriteLine("Enter a Row:");
        int Row = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter a Column:");
        int Column = Convert.ToInt32(Console.ReadLine());
		
		int [,] Array = new int[Row,Column];
		
		for(int i = 0;i<Row;i++){
			for(int j = 0;j<Column;j++){
				Array[i][j] = Convert.ToInt32(Console.ReadLine())
			}
		}
		
		// copy 2D Array element into 1D Array
		int [] OneDimensionality = new Array[ Row * Column ];
		
		int OneDArray = 0;
		for(int i = 0;i<Row;i++){
			for(int j = 0;j<Column;j++){
				OneDimensionality[OneDArray] = Array[i][j];
				
				OneDArray++;
				
			}
		}
		
		for(int i = 0;i<row;i++){
		Console.WriteLine(OneDimensionality);
		}
		
	}
}