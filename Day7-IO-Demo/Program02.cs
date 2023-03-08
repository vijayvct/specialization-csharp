using System;
using System.IO;
using System.Text;

namespace Day7_IO_Demo;

class Program02
{
    //FileStream class to read and write data to the file 
    static void WriteData(string path,string data)
    {
        //Creating FileStream Instance 
        FileStream stream = new FileStream(path,FileMode.Create,FileAccess.Write);

        //Byte Array 
        byte [] datatowrite=new byte[data.Length];

        //Converting string into bytes 
        datatowrite = Encoding.ASCII.GetBytes(data);

        //Write data to file 
        stream.Write(datatowrite,0,datatowrite.Length);

        stream.Close();

        Console.WriteLine("Data Written Successfully....");
    }

    static void ReadData(string path)
    {
        //Creating the FileStream instance 
        FileStream stream = new FileStream(path,FileMode.Open,FileAccess.Read);

        //Byte Array 
        byte [] datatoread = new byte[stream.Length];

        //Reading data from the file 
        stream.Read(datatoread,0,datatoread.Length);

        //Converting Byte array to string 
        string data = Encoding.ASCII.GetString(datatoread);

        Console.WriteLine("\n\nData from file");
        Console.WriteLine(data);

        // Console.WriteLine("\n\nData from file");
        // foreach(var item in datatoread)
        // {
        //     Console.Write(item);
        // }

        stream.Close();
    }
    static void Main(string[] args)
    {
        string filepath =@"C:\Demos\DataNew\demo1.txt";
        string data ="Welcome to File IO, This File is created using FileStream Class";

        WriteData(filepath,data);
        ReadData(filepath);
    }
}