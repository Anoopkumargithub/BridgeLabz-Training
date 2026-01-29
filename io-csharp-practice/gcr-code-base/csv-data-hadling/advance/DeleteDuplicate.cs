using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DeleteDuplicate
{
    public static void Main()
    {
        string filePath = "employees.csv";
        
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        DetectDuplicates(filePath);
    }

    public static void DetectDuplicates(string filePath)
    {
        var records = new List<Dictionary<string, string>>();
        var idCount = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string[] headers = null;
            string line;
            int lineNumber = 0;

            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;

                if (lineNumber == 1)
                {
                    headers = line.Split(',');
                    continue;
                }

                string[] values = line.Split(',');
                var record = new Dictionary<string, string>();

                for (int i = 0; i < headers.Length; i++)
                {
                    record[headers[i].Trim()] = values[i].Trim();
                }

                records.Add(record);

                if (record.ContainsKey("ID"))
                {
                    string id = record["ID"];
                    if (!idCount.ContainsKey(id))
                        idCount[id] = 0;
                    idCount[id]++;
                }
            }
        }

        Console.WriteLine("Duplicate Records:");
        Console.WriteLine(new string('-', 50));

        var duplicates = records.Where(r => idCount[r["ID"]] > 1);

        if (duplicates.Count() == 0)
        {
            Console.WriteLine("No duplicates found.");
            return;
        }

        foreach (var record in duplicates.OrderBy(r => r["ID"]))
        {
            Console.WriteLine(string.Join(", ", record.Select(kvp => $"{kvp.Key}: {kvp.Value}")));
        }
    }
}