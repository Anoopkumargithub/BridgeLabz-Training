using System;
using System.IO;

class ReadAndCountRows
{
    static void Main()
    {
        string filePath = "employees.csv";
        try
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string [] columns = line.Split(',');
                    Console.WriteLine("ID: " + columns[0] + " Name: " + columns[1]);
                    count++;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Total Line: " + count);
        }
        catch (Exception e)
        {
             Console.WriteLine(e.Message);
        }
    }
}