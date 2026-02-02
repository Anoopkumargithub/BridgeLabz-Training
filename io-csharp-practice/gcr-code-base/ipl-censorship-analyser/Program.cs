using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to IPL Censorship Analyser");
        

        IPLUtility utility = new IPLUtility();

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Process JSON file");
            Console.WriteLine("2. Process CSV file");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter your choice (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ProcessJsonFile(utility);
                    break;
                case "2":
                    ProcessCsvFile(utility);
                    break;
                case "3":
                    Console.WriteLine("\nThank you for using IPL Censorship Analyser!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ProcessJsonFile(IPLUtility utility)
    {
        
        string filePath = "sample.json";

        // Read JSON file
        JObject jsonData = utility.ReadJsonFile(filePath);
        if (jsonData == null)
            return;

        // Apply censorship
        JObject censoredData = utility.ApplyCensorshipToJson(jsonData);

        // Display censored data
        utility.DisplayCensoredData(censoredData, "JSON");
    }

    static void ProcessCsvFile(IPLUtility utility)
    {
        string filePath = "sample.csv";

        // Read CSV file
        List<string[]> csvData = utility.ReadCSVFile(filePath);
        if (csvData == null)
            return;

        // Apply censorship
        List<string[]> censoredData = utility.ApplyCensorshipToCsv(csvData);

        // Display censored data
        utility.DisplayCensoredCsvData(censoredData);
    }
}