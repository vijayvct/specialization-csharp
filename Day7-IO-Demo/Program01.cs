using System.IO;

namespace Day7_IO_Demo;

class Program01
{
    static void Main(string[] args)
    {
        string path=@"C:\Demos";

        if(Directory.Exists(path))
        {
            Console.WriteLine("Directory Exits \n");

            DirectoryInfo directoryInfo= new DirectoryInfo(path);

            Console.WriteLine("Name = "+directoryInfo.Name);
            Console.WriteLine("Full Name = "+directoryInfo.FullName);
            Console.WriteLine("Creation Time = "+directoryInfo.CreationTime);
            Console.WriteLine("No of Directories in Directory = "+directoryInfo.GetDirectories().Length);
            Console.WriteLine("No of Files in Directory = "+directoryInfo.GetFiles().Length);

            Console.WriteLine("\nList of files");
            foreach(var file in directoryInfo.GetFiles())
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine("\n\nList of Directories");
            foreach(var dir in directoryInfo.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }
        }
        else
        {
            Directory.CreateDirectory(path);

            Console.WriteLine($"{path} created successfully");
        }
    }
}