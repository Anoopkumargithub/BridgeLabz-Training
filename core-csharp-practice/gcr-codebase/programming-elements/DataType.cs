using System;

class DataType
{
    static void Main()
    {
        // Basic data types
        int A = 5;
        long B = A;            // implicit conversion (int → long)
        float C = 5.0f;
        double D = C;          // implicit conversion (float → double)
        char E = 'A';
        bool F = true;

        // Explicit type conversions
        int FromLong = (int)B;     // explicit (long → int)
        int FromFloat = (int)C;    // explicit (float → int)
        int FromDouble = (int)D;   // explicit (double → int)
        int FromChar = (int)E;     // explicit (char → int → ASCII)
        
        // Output
        Console.WriteLine($"{A} is int {A is int}");
        Console.WriteLine($"{B} is long {B is long}");
        Console.WriteLine($"{C} is float {C is float}");
        Console.WriteLine($"{D} is double {D is double}");
        Console.WriteLine($"{E} is char {E is char}");
        Console.WriteLine($"{F} is bool {F is bool}");

        Console.WriteLine("Type Conversion");
        Console.WriteLine($"int to long (implicit): {B}");
        Console.WriteLine($"float to double (implicit): {D}");
        Console.WriteLine($"long to int (explicit): {FromLong}");
        Console.WriteLine($"float to int (explicit): {FromFloat}");
        Console.WriteLine($"double to int (explicit): {FromDouble}");
        Console.WriteLine($"char to int (ASCII): {FromChar}");
    }
}