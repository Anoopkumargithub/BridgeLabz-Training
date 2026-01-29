using System.IO;

class ModifyCSV
{
    static void Main()
    {
        string inputPath = "employees.csv";
        string outputPath = "employees_updated.csv";
        
        try
        {
            using (StreamReader sr = new StreamReader(inputPath))
            using (StreamWriter sw = new StreamWriter(outputPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    
                    // Assuming: ID, Name, Department, Salary
                    if (columns[2].Trim() == "IT" && decimal.TryParse(columns[3], out decimal salary))
                    {
                        decimal newSalary = salary * 1.10m;
                        columns[3] = newSalary.ToString();
                    }
                    
                    sw.WriteLine(string.Join(",", columns));
                }
            }
            
            System.Console.WriteLine("File updated successfully: " + outputPath);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}