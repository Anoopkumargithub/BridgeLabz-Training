using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema; 

class ValidateJsonSchema
{
    static void Main()
    {
        string jsonData = @"{
            ""name"": ""John"",
            ""age"": 30,
            ""email"": ""john@example.com""
        }";

        string schemaData = @"{
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""age"": { ""type"": ""integer"" },
                ""email"": { ""type"": ""string"" }
            },
            ""required"": [""name"", ""age""]
        }";

        ValidateJson(jsonData, schemaData);
    }

    static void ValidateJson(string json, string schema)
    {
        try
        {
            JToken jToken = JToken.Parse(json);
            JSchema jSchema = JSchema.Parse(schema);
            
            if (jToken.IsValid(jSchema))
            {
                Console.WriteLine("JSON is valid against the schema");
            }
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Validation failed: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}