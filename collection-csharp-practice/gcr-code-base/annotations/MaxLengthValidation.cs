using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }
    public MaxLengthAttribute(int length) => Length = length;
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        var field = typeof(User).GetField("Username");
        var attr = field.GetCustomAttribute<MaxLengthAttribute>();

        if (username.Length > attr.Length)
            throw new ArgumentException("Username too long");

        Username = username;
    }
}

class Program8
{
    static void Main()
    {
        User u = new User("Abhishek");
        Console.WriteLine(u.Username);
    }
}
