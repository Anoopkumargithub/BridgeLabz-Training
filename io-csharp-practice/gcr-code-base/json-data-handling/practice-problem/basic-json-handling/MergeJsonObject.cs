using System;
using Newtonsoft.Json;

class MergeJsonObject
{
    static void Main()
    {
        var address = new
        {
            City = "Mathura",
            ZipCode = "12345"
        };

        var contact = new
        {
            Email = "adam.carter@example.com",
            Phone = "555-1234"
        };
        var merged = new
        {
            Name = "Adam Carter",
            Age = 21,
            Subjects = new string[] { "Mathematics", "Physics", "Chemistry" },
            Address = address,
            Contact = contact
        };
        string jsonString = JsonConvert.SerializeObject(merged, Formatting.Indented);
        Console.WriteLine(jsonString);
    }
}