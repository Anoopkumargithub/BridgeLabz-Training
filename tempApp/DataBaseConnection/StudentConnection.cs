using Microsoft.Data.SqlClient;

class StudentConnection
{
    public static void Main(String[] args)
    {
        string connectionString = "Server=localhost,1433;" +
        "Database=EMPLOYEE_DB;" +
        "User Id=sa;" +
        "Password=Admin@123;" +
        "TrustServerCertificate=True;";

        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        Console.WriteLine("Connection established");

        // ---------- CREATE (INSERT) ----------
        string insertQuery = @"
            INSERT INTO Employees (EmployeeID, Name, DepartmentID)
            VALUES (@EmployeeID, @Name, @DepartmentID)";

        using SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

        Console.Write("Enter Employee ID: ");
        int employeeID = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Department ID: ");
        int departmentID = int.Parse(Console.ReadLine());

        insertCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
        insertCommand.Parameters.AddWithValue("@Name", name);
        insertCommand.Parameters.AddWithValue("@DepartmentID", departmentID);

        int rows = insertCommand.ExecuteNonQuery();
        Console.WriteLine($"{rows} employee added");


        // ---------- UPDATE ----------
string updateQuery = @"
    UPDATE Employees
    SET Name = @Name,
        DepartmentID = @DepartmentID
    WHERE EmployeeID = @EmployeeID";

using SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

Console.Write("Enter Employee ID to update: ");
int employeeID = int.Parse(Console.ReadLine());

Console.Write("Enter new Name: ");
string name = Console.ReadLine();

Console.Write("Enter new Department ID: ");
int departmentID = int.Parse(Console.ReadLine());

updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
updateCommand.Parameters.AddWithValue("@Name", name);
updateCommand.Parameters.AddWithValue("@DepartmentID", departmentID);

int rows = updateCommand.ExecuteNonQuery();

if (rows > 0)
{
    Console.WriteLine($"{rows} employee updated");
}
else
{
    Console.WriteLine("Employee not found");
}




        // ---------- READ (SELECT) ----------
        string selectQuery = "SELECT EmployeeID, Name, DepartmentID FROM Employees";

        using SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
        using SqlDataReader reader = selectCommand.ExecuteReader();

        Console.WriteLine("\n{0,-15} {1,-20} {2,-15}", "EmployeeID", "Name", "DepartmentID");
        Console.WriteLine(new string('-', 50));
        
        while (reader.Read())
        {
            Console.WriteLine("{0,-15} {1,-20} {2,-15}", 
                reader["EmployeeID"], reader["Name"], reader["DepartmentID"]);
        }
    }
}

class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public int DepartmentID { get; set; }
}