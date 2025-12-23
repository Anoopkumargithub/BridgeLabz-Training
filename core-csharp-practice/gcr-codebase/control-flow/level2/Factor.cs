using system;

class Factor{
	static void Main(){
		
		Console.WriteLine("Enter a Number: ");
		int Number= Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Factor of " + Number);
		
		for(int i = 1; i<= Number;i++){
			
			if(Number % i == 0) Console.WriteLine(i);
			
		}
	}
}