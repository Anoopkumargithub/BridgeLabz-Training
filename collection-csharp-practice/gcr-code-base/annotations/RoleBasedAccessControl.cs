using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    public RoleAllowedAttribute(string role) => Role = role;
}

[RoleAllowed("ADMIN")]
class AdminService
{
    public void DeleteUser()
    {
        Console.WriteLine("User deleted");
    }
}

class Program9
{
    static void Main()
    {
        string currentRole = "USER";
        var attr = typeof(AdminService).GetCustomAttribute<RoleAllowedAttribute>();

        if (attr.Role == currentRole)
            new AdminService().DeleteUser();
        else
            Console.WriteLine("Access Denied!");
    }
}
