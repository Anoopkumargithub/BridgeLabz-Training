using System;
using System.IO;
using System.Text;

class FilterStream
{
    static void Main()
    {
        string sourceFile = "file1.txt";
        string destinationFile = "file2.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Handle encoding explicitly
            Encoding encoding = Encoding.UTF8;

            FileStream readFs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
            BufferedStream bufferedRead = new BufferedStream(readFs);

            StreamReader reader = new StreamReader(bufferedRead, encoding);

            FileStream writeFs = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);
            BufferedStream bufferedWrite = new BufferedStream(writeFs);

            StreamWriter writer = new StreamWriter(bufferedWrite, encoding);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }

            writer.Flush();

            reader.Close();
            writer.Close();

            Console.WriteLine("File converted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
