using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; set; } = "HIGH";
}

class Service
{
    [ImportantMethod]
    public void Save() { }

    [ImportantMethod(Level = "LOW")]
    public void Load() { }
}

class Program6
{
    static void Main()
    {
        foreach (var method in typeof(Service).GetMethods())
        {
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
                Console.WriteLine($"{method.Name} - Level: {attr.Level}");
        }
    }
}
