using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class BugTracker
{
    [BugReport("Null reference bug")]
    [BugReport("Performance issue")]
    public void Process()
    {
        Console.WriteLine("Processing...");
    }
}

class Program5
{
    static void Main()
    {
        MethodInfo method = typeof(BugTracker).GetMethod("Process");
        var bugs = method.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute bug in bugs)
            Console.WriteLine("Bug: " + bug.Description);
    }
}
