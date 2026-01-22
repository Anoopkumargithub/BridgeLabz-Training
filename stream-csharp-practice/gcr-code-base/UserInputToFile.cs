using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = "file1.txt";

        StreamReader reader = null;
        StreamWriter writer = null;

        try
        {
            // Read input from console using StreamReader
            reader = new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter your name: ");
            string name = reader.ReadLine();

            Console.Write("Enter your age: ");
            string age = reader.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();

            // Write data into file using StreamWriter
            writer = new StreamWriter(filePath, false);

            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);

            Console.WriteLine("User information saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            reader?.Close();
            writer?.Close();
        }
    }
}
