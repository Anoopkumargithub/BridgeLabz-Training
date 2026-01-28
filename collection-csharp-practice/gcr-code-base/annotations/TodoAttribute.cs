using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; set; } = "MEDIUM";

    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
    }
}

class Project
{
    [Todo("Add validation", "Rahul", Priority = "HIGH")]
    public void Register() { }

    [Todo("Optimize performance", "Amit")]
    public void FetchData() { }
}

class Program7
{
    static void Main()
    {
        foreach (var method in typeof(Project).GetMethods())
        {
            var todo = method.GetCustomAttribute<TodoAttribute>();
            if (todo != null)
            {
                Console.WriteLine($"{method.Name} → {todo.Task}, {todo.AssignedTo}, {todo.Priority}");
            }
        }
    }
}
