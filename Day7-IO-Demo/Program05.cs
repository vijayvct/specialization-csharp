using System.IO;
using System.Xml.Serialization;

namespace Day7_IO_Demo;

class Program05
{
    static void SerializeData(string path,Employee employee)
    {
        //Creating XML Serializer Instance
        XmlSerializer serializer= new XmlSerializer(typeof(Employee));

        //Creating FileStream Object 
        FileStream stream = new FileStream(path,FileMode.Create,FileAccess.Write);

        serializer.Serialize(stream,employee);

        stream.Close();
        Console.WriteLine("Serialization Done......");
    }

    static void DeserializeData(string path)
    {
        //Creating XML Serializer Instance
        XmlSerializer serializer= new XmlSerializer(typeof(Employee));

        //Creating FileStream Object 
        FileStream stream = new FileStream(path,FileMode.Open,FileAccess.Read);

        Employee emp = (Employee) serializer.Deserialize(stream);

        stream.Close();
        Console.WriteLine("Deserialization Done");
        Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, DOB = {emp.DOB}");
    }

    static void Main(string[] args)
    {
        string path = @"C:\Demos\DataNew\employee.xml";
        Employee employee= new Employee
        {
            Id=101,Name="Malcolm",DOB=DateTime.Now.AddYears(-25)
        };

        SerializeData(path,employee);
        DeserializeData(path);
    }
}