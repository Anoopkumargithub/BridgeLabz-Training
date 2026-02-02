using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal class IPLUtility
{
    private JArray matchesArray = null;

    // Read JSON file - handles both object and array formats
    public JObject ReadJsonFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"JSON file not found: {filePath}");
                return null;
            }
            string jsonContent = File.ReadAllText(filePath);
            JToken token = JToken.Parse(jsonContent);

            if (token.Type == JTokenType.Array)
            {
                matchesArray = (JArray)token;
                JObject wrappedData = new JObject();
                wrappedData["matches"] = matchesArray;
                Console.WriteLine($"JSON file read successfully from: {filePath} (Array format detected)");
                return wrappedData;
            }
            else if (token.Type == JTokenType.Object)
            {
                // If it's already an object, use it directly
                JObject data = (JObject)token;
                if (data["matches"] != null)
                {
                    matchesArray = (JArray)data["matches"];
                }
                Console.WriteLine($"JSON file read successfully from: {filePath} (Object format detected)");
                return data;
            }
            else
            {
                Console.WriteLine("Invalid JSON format. Expected object or array.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading JSON file: {ex.Message}");
            return null;
        }
    }

    // Read CSV file
    public List<string[]> ReadCSVFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"CSV file not found: {filePath}");
                return null;
            }
            
            string[] lines = File.ReadAllLines(filePath);
            List<string[]> csvData = new List<string[]>();
            
            foreach (string line in lines)
            {
                csvData.Add(line.Split(','));
            }
            
            Console.WriteLine($"CSV file read successfully from: {filePath} ({csvData.Count} rows)");
            return csvData;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading CSV file: {ex.Message}");
            return null;
        }
    }

    // Censor team names (replace last word with ***)
    public string CensorTeamName(string teamName)
    {
        if (string.IsNullOrWhiteSpace(teamName))
            return teamName;
        
        string[] parts = teamName.Trim().Split(' ');
        if (parts.Length > 1)
        {
            parts[parts.Length - 1] = "***";
            return string.Join(" ", parts);
        }
        return "***";
    }

    // Redact player names
    public string RedactPlayerName(string playerName)
    {
        if (string.IsNullOrWhiteSpace(playerName))
            return playerName;
        
        return "REDACTED";
    }

    // Apply censorship to JSON data
    public JObject ApplyCensorshipToJson(JObject data)
    {
        try
        {
            var matches = data["matches"] as JArray;
            
            if (matches != null)
            {
                foreach (var match in matches)
                {
                    // Censor team names
                    if (match["team1"] != null)
                        match["team1"] = CensorTeamName(match["team1"].ToString());
                    
                    if (match["team2"] != null)
                        match["team2"] = CensorTeamName(match["team2"].ToString());
                    
                    // Redact player of the match
                    if (match["player_of_match"] != null)
                        match["player_of_match"] = RedactPlayerName(match["player_of_match"].ToString());
                    
                    // Redact other player fields if they exist
                    if (match["captain1"] != null)
                        match["captain1"] = RedactPlayerName(match["captain1"].ToString());
                    
                    if (match["captain2"] != null)
                        match["captain2"] = RedactPlayerName(match["captain2"].ToString());
                }
            }
            
            Console.WriteLine("Censorship applied to JSON data");
            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying censorship to JSON: {ex.Message}");
            return data;
        }
    }

    // Apply censorship to CSV data
    public List<string[]> ApplyCensorshipToCsv(List<string[]> csvData)
    {
        try
        {
            if (csvData == null || csvData.Count == 0)
                return csvData;
            
            // Find column indices (assuming headers are in first row)
            string[] headers = csvData[0];
            int team1Index = Array.IndexOf(headers, "team1");
            int team2Index = Array.IndexOf(headers, "team2");
            int playerOfMatchIndex = Array.IndexOf(headers, "player_of_match");
            int captain1Index = Array.IndexOf(headers, "captain1");
            int captain2Index = Array.IndexOf(headers, "captain2");
            
            // Apply censorship to data rows (skip header)
            for (int i = 1; i < csvData.Count; i++)
            {
                string[] row = csvData[i];
                
                if (team1Index >= 0 && team1Index < row.Length)
                    row[team1Index] = CensorTeamName(row[team1Index]);
                
                if (team2Index >= 0 && team2Index < row.Length)
                    row[team2Index] = CensorTeamName(row[team2Index]);
                
                if (playerOfMatchIndex >= 0 && playerOfMatchIndex < row.Length)
                    row[playerOfMatchIndex] = RedactPlayerName(row[playerOfMatchIndex]);
                
                if (captain1Index >= 0 && captain1Index < row.Length)
                    row[captain1Index] = RedactPlayerName(row[captain1Index]);
                
                if (captain2Index >= 0 && captain2Index < row.Length)
                    row[captain2Index] = RedactPlayerName(row[captain2Index]);
                
                csvData[i] = row;
            }
            
            Console.WriteLine("Censorship applied to CSV data");
            return csvData;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying censorship to CSV: {ex.Message}");
            return csvData;
        }
    }

    // Display censored data
    public void DisplayCensoredData(JObject data, string dataType = "JSON")
    {
        Console.WriteLine($"\n --- Censored {dataType} Data ---");
        JToken outputData;
        if (matchesArray != null && data["matches"] != null)
        {
            outputData = data["matches"];
        }
        else
        {
            outputData = data;
        }
        Console.WriteLine(JsonConvert.SerializeObject(outputData, Formatting.Indented));
    }

    public void DisplayCensoredCsvData(List<string[]> csvData)
    {
        Console.WriteLine($"\n --- Censored CSV Data ---");
        foreach (string[] row in csvData)
        {
            Console.WriteLine(string.Join(" | ", row));
        }
    }
}
