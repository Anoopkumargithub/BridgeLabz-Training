using System;
using System.IO;

class FilterRecord
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
                    if(columns[3] == "50000")
                    {
                        Console.WriteLine("ID: " + columns[0] + " Name: " + columns[1]);
                    }
                }
            }
        }
        catch (Exception e)
        {
             Console.WriteLine(e.Message);
        }
    }
}