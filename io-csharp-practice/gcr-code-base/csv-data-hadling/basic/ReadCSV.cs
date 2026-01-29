using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string [] columns = line.Split(',');
                    Console.WriteLine("ID: " + columns[0] + " Name: " + columns[1]);
                    Console.WriteLine();
                }
            }
        }
        catch (Exception e)
        {
             Console.WriteLine(e.Message);
        }
    }
}