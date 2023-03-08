using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day7_IO_Demo;

class Program04
{
    static void SerializeData(string path,Employee employee)
    {
        //Creating a Formatter
        BinaryFormatter formatter=new BinaryFormatter();

        //Creating FileStream
        FileStream stream = new FileStream(path,FileMode.Create,FileAccess.Write);

        formatter.Serialize(stream,employee);

        stream.Close();
        Console.WriteLine("Serialization Done......");
    }

    static void DeserializeData(string path)
    {
        //Creating a Formatter
        BinaryFormatter formatter=new BinaryFormatter();

        //Creating FileStream
        FileStream stream = new FileStream(path,FileMode.Open,FileAccess.Read);

        Employee emp =(Employee)formatter.Deserialize(stream);

        stream.Close();

        Console.WriteLine("Deserialization Done");
        Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, DOB = {emp.DOB}");
    }

    static void Main(string[] args)
    {
        string path = @"C:\Demos\DataNew\employee.txt";
        Employee employee= new Employee
        {
            Id=101,Name="Malcolm",DOB=DateTime.Now.AddYears(-25)
        };

        SerializeData(path,employee);
        DeserializeData(path);
    }
}