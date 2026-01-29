using System;
using System.IO;

class WriteCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Id, Name, Department, Salary");
                sw.WriteLine("101, Jhon Doe, CS, 250000");
                sw.WriteLine("105, Adam, CS, 200000");
                System.Console.WriteLine("CSV file Written Successfully");
            }
        }
        catch (Exception e)
        {
             Console.WriteLine(e.Message);
        }
    }
}