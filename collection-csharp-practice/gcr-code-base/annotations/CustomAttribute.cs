using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("HIGH", "Abhishek")]
    public void CompleteTask()
    {
        Console.WriteLine("Task Completed");
    }
}

class Program4
{
    static void Main()
    {
        MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute attr =
            (TaskInfoAttribute)Attribute.GetCustomAttribute(
                method, typeof(TaskInfoAttribute));

        Console.WriteLine("Priority: " + attr.Priority);
        Console.WriteLine("Assigned To: " + attr.AssignedTo);
    }
}
