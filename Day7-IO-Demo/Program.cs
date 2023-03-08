using System.IO;

namespace Day7_IO_Demo;
class Program
{
    static void Main(string[] args)
    {
        string path =@"C:\Demos\DataNew\sample.txt";

        if(File.Exists(path))
        {
            Console.WriteLine("File is Present");

            FileInfo fileInfo= new FileInfo(path);
            Console.WriteLine("Name = "+fileInfo.Name);
            Console.WriteLine("Full Name = "+fileInfo.FullName);
            Console.WriteLine("Extension = "+fileInfo.Extension);
            Console.WriteLine("Parent Directoty = "+fileInfo.DirectoryName);
            Console.WriteLine("Creation Time = "+fileInfo.CreationTime.ToString());
            Console.WriteLine("Last Access Time = "+fileInfo.LastAccessTime.ToString());
            Console.WriteLine("Last Modified Time = "+fileInfo.LastWriteTime.ToString());
        }
        else
        {
            File.Create(path);

            Console.WriteLine($"{path} created successfully");
        }
    }
}
