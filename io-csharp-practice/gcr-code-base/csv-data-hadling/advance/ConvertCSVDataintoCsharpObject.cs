using System.Collections.Generic;
using System.IO;

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Grade { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}

class ConvertCSVDataintoCsharpObject
{
    static void Main()
    {
        List<Student> students = [];
        string[] lines = File.ReadAllLines("Student.csv");

        foreach (var line in lines.Skip(1))
        {
            var values = line.Split(',');
            Student student = new()
            {
                Name = values[0],
                Age = int.Parse(values[1]),
                Grade = values[2]
            };
            students.Add(student);
        }

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

