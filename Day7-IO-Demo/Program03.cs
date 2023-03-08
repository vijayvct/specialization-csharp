using System.IO;

namespace Day7_IO_Demo;

class Program03
{
    static void WriteData(string path)
    {
        StreamWriter writer=new StreamWriter(path);

        writer.WriteLine("Welcome to StreamReader and StreamWriter");
        writer.WriteLine("Hello User.....");
        writer.WriteLine(DateTime.Now.ToString());

        writer.Close();

        Console.WriteLine("Data written Successfully...");
    }

    static void ReadData(string path)
    {
        StreamReader reader = new StreamReader(path);

        string data;

        Console.WriteLine("\nData from file");

        //line by line 
        // while((data=reader.ReadLine())!=null)
        // {
        //     Console.WriteLine(data);
        // }

        Console.WriteLine(reader.ReadToEnd());
    }

    static void Main(string[] args)
    {
        string path =@"C:\Demos\DataNew\stream.txt";
        WriteData(path);
        ReadData(path);
    }
}