using System;
using System.Threading;
class FileProcessor
{
public string FileName { get; set; }
public int ChunkSize { get; set; }
public FileProcessor(string fileName, int chunkSize)
{
FileName = fileName;
ChunkSize = chunkSize;
}
}
class Program
{
static void ProcessFile(object obj)
{
FileProcessor processor = obj as FileProcessor;
if (processor != null)
{
Console.WriteLine($"Processing file: {processor.FileName}");
Console.WriteLine($"Chunk size: {processor.ChunkSize} bytes");
// Simulate processing
for (int i = 1; i <= 5; i++)
{
Console.WriteLine($"{processor.FileName}: Processing chunk {i}");
Thread.Sleep(500);
}
Console.WriteLine($"{processor.FileName}: Processing complete!");
}
}
static void Main(string[] args)
{
FileProcessor processor1 = new FileProcessor("data.txt", 1024);
FileProcessor processor2 = new FileProcessor("config.xml", 512);
Thread thread1 = new Thread(ProcessFile);

Thread thread2 = new Thread(ProcessFile);
thread1.Start(processor1);
thread2.Start(processor2);
thread1.Join();
thread2.Join();
}
}