using System;
using System.IO;

class ReadAndWriteATextFile
{
    static void Main()
    {
        string sourcePath = "file1.txt";
        string destinationPath = "file2.txt";

        // Check if source file exists
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        FileStream sourceStream = null;
        FileStream destinationStream = null;

        try
        {
            sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

            int data;
            while ((data = sourceStream.ReadByte()) != -1)
            {
                destinationStream.WriteByte((byte)data);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        finally
        {
            sourceStream?.Close();
            destinationStream?.Close();
        }
    }
}