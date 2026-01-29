using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSV
{
    static void Main()
    {
        string csvFilePath = "data.csv";
        ValidateCSVData(csvFilePath);
    }

    static void ValidateCSVData(string filePath)
    {
        string emailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
        string phonePattern = @"^\d{10}$";
        Regex emailRegex = new Regex(emailPattern);
        Regex phoneRegex = new Regex(phonePattern);

        int rowNumber = 0;
        bool hasErrors = false;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] headers = null;
                int emailIndex = -1;
                int phoneIndex = -1;

                while ((line = reader.ReadLine()) != null)
                {
                    rowNumber++;

                    if (rowNumber == 1)
                    {
                        headers = line.Split(',');
                        emailIndex = Array.IndexOf(headers, "Email");
                        phoneIndex = Array.IndexOf(headers, "Phone");
                        continue;
                    }

                    string[] values = line.Split(',');
                    List<string> errors = new List<string>();

                    if (emailIndex >= 0 && emailIndex < values.Length)
                    {
                        if (!emailRegex.IsMatch(values[emailIndex].Trim()))
                            errors.Add($"Invalid email format: {values[emailIndex]}");
                    }

                    if (phoneIndex >= 0 && phoneIndex < values.Length)
                    {
                        if (!phoneRegex.IsMatch(values[phoneIndex].Trim()))
                            errors.Add($"Phone must contain exactly 10 digits: {values[phoneIndex]}");
                    }

                    if (errors.Count > 0)
                    {
                        hasErrors = true;
                        Console.WriteLine($"Row {rowNumber}: {string.Join(", ", errors)}");
                    }
                }
            }

            if (!hasErrors)
                Console.WriteLine("All CSV data is valid!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
}