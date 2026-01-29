using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SortCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        try
        {
            var employees = new List<(string Id, string Name, decimal Salary)>();
            
            using var sr = new StreamReader(filePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] columns = line.Split(',');
                if (columns.Length >= 4 && decimal.TryParse(columns[3], out decimal salary))
                {
                    employees.Add((columns[0], columns[1], salary));
                }
            }
            
            var top5 = employees.OrderByDescending(e => e.Salary).Take(5);
            
            foreach (var emp in top5)
            {
                Console.WriteLine($"ID: {emp.Id} Name: {emp.Name} Salary: {emp.Salary}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}