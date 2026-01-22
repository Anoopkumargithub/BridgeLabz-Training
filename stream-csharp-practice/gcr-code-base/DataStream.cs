using System;
using System.IO;

class DataStream
{
    static void Main()
    {
        string filePath = "file1.dat";

        try
        {
            // WRITE DATA
            FileStream fsWrite = new FileStream(filePath, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fsWrite);

            writer.Write(101);            // Roll Number
            writer.Write("Anoop");        // Name
            writer.Write(8.7);             // GPA

            writer.Close();
            fsWrite.Close();

            Console.WriteLine("Student data stored successfully.");

            // READ DATA
            FileStream fsRead = new FileStream(filePath, FileMode.Open);
            BinaryReader reader = new BinaryReader(fsRead);

            int rollNo = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            reader.Close();
            fsRead.Close();

            Console.WriteLine("\nRetrieved Student Data:");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("GPA: " + gpa);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
