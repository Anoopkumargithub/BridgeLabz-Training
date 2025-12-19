using System;

class Operators{
static void Main(){
	
	int a = 10;
	int b = 5;
		
	// Arithmetic Operators
	Console.WriteLine("Arithmetic Operators");
	Console.WriteLine($"{a} + {b} = {a+b}  // Addition");
	Console.WriteLine($"{a} - {b} = {a-b}  // Subtraction");
	Console.WriteLine($"{a} * {b} = {a*b}  // Multiplication");
	Console.WriteLine($"{a} / {b} = {a/b}  // Division");
	Console.WriteLine($"{a} % {b} = {a%b}  // Modulus");
	
	Console.WriteLine(" ");
	
	// Relational Operators
	Console.WriteLine("Relational Operators");
	Console.WriteLine($"{a} == {b}: {a == b} // Equal to"); 
	Console.WriteLine($"{a} != {b}: {a != b} // Not Equal to"); 
	Console.WriteLine($"{a} > {b}: {a > b} // Greater than"); 
	Console.WriteLine($"{a} < {b}: {a < b} // Less than"); 
	Console.WriteLine($"{a} >= {b}: {a >= b} // Greater than or equal to "); 
	Console.WriteLine($"{a} <= {b}: {a <= b} // Less than or equal to"); 
	
	Console.WriteLine(" ");
	
	// Logical Operators
	Console.WriteLine("Logical Operators");
	bool c = true;
	bool d = false;
	Console.WriteLine($"{c} && {d}: {c && d} //Logical ADD");
	Console.WriteLine($"{c} || {d}: {c || d} //Logical OR");
	Console.WriteLine($"!{c} : {!c} //Logical NOT");
	
	Console.WriteLine(" ");
	
	// Assignment Operators
	Console.WriteLine("Assignment Operators");
	a += b;
	Console.WriteLine($"{a} += {b} = {a}  // Addition Assignment");
	a -= b;
	Console.WriteLine($"{a} -= {b} = {a}  // Subtraction Assignment");
	a *= b;
	Console.WriteLine($"{a} *= {b} = {a}  // Multiplication Assignment");
	a /= b;
	Console.WriteLine($"{a} /= {b} = {a}  // Division Assignment");
	a %= b;
	Console.WriteLine($"{a} %= {b} = {a}  // Modulus Assignment");
	
	Console.WriteLine(" ");
	
	// Unary Operators
	
	Console.WriteLine("Unary Operators");
	Console.WriteLine($"{a} : {+a}  // Unary Plus");
	Console.WriteLine($"{a} : {-a}  // Unary minus");
	Console.WriteLine($"++{a} : {++a}  // Pre-Increment");
	Console.WriteLine($"--{a} : {--a}  // Pre-Decrement");
	Console.WriteLine($"{a}++ : {a++}  // Post-Increment");
	Console.WriteLine($"{a}-- : {a--}  // Post-Decrement");
	Console.WriteLine($"!{c} : {!c}  // Logical Complement");
	
	Console.WriteLine(" ");
	
	// Ternary Operators
	Console.WriteLine("Ternary Operators");
	
	int Max = (a > b)?a:b;
	Console.WriteLine($"( {a} > {b} )? {a} : {b} -> Max");
	
	Console.WriteLine(" ");

	// is Operators
	Console.WriteLine("is Operators");
	Console.WriteLine($"{a} is int: {a is int}");
	
	}
}