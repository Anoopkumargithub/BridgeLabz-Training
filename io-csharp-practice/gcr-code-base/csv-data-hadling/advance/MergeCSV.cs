using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MergeCSV
{
    static void Main()
    {
        string file1 = "student.csv";
        string file2 = "student2.csv";
        string outputFile = "merged_students.csv";

        try
        {
            // Read both CSV files
            var students1 = ReadCSV(file1);
            var students2 = ReadCSV(file2);

            // Merge based on ID
            var merged = students1.Join(
                students2,
                s1 => s1["Age"],
                s2 => s2["Age"],
                (s1, s2) => CombineDictionaries(s1, s2)
            ).ToList();

            // Write merged data to output file
            WriteCSV(outputFile, merged);

            Console.WriteLine($"Files merged successfully! Output: {outputFile}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static List<Dictionary<string, string>> ReadCSV(string filePath)
    {
        var data = new List<Dictionary<string, string>>();
        var lines = File.ReadAllLines(filePath);
        var headers = lines[0].Split(',');

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var row = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                row[headers[j].Trim()] = values[j].Trim();
            }
            data.Add(row);
        }
        return data;
    }

    static Dictionary<string, string> CombineDictionaries(Dictionary<string, string> dict1, Dictionary<string, string> dict2)
    {
        var combined = new Dictionary<string, string>(dict1);
        foreach (var kvp in dict2)
        {
            if (!combined.ContainsKey(kvp.Key))
            {
                combined[kvp.Key] = kvp.Value;
            }
        }
        return combined;
    }

    static void WriteCSV(string filePath, List<Dictionary<string, string>> data)
    {
        if (data.Count == 0) return;

        var headers = data[0].Keys.ToList();
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine(string.Join(",", headers));
            foreach (var row in data)
            {
                var values = headers.Select(h => row[h]);
                writer.WriteLine(string.Join(",", values));
            }
        }
    }
}