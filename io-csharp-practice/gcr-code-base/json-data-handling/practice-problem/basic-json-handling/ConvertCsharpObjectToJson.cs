using System;
using Newtonsoft.Json;

class ConvertCsharpObjectToJson
{
    static void Main()
    {
        var car = new Car { Make = "Toyota", Model = "Camry", Year = 2022 };
        string json = JsonConvert.SerializeObject(car);
        Console.WriteLine(json);
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

