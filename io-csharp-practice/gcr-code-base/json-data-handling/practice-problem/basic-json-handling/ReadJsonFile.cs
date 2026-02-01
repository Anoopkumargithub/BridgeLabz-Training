using System;
using System.IO;
using Newtonsoft.Json.Linq;

class ReadJsonFile
{
    static void Main()
    {
        string filePath = "data.json";
        string jsonContent = File.ReadAllText(filePath);
        JObject data = JObject.Parse(jsonContent);
        
        string name = data["Name"]?.ToString();
        string age = data["Age"]?.ToString();
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }
}