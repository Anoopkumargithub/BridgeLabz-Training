using System.IO;

class SearchRecord
{
    static void Main()
    {
        string filePath = "employees.csv";
        string searchName = "John Doe"; 
        
    try
    {
        using StreamReader sr = new(filePath);
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] columns = line.Split(',');
            if (columns.Length > 3 && columns[1].Trim() == searchName)
            {
                Console.WriteLine($"Name: {columns[1]}, Department: {columns[2]}, Salary: {columns[3]}");
            }
        }
    }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}