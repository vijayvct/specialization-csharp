using System;

namespace Day1_Demo;

class Program04
{
    static void Main(string[] args)
    {
        //Implicitly Typed Variables
        var rollno =123;
        var name="James";
        var dob=DateTime.Now.AddYears(-20);

        Console.WriteLine("Roll No = "+rollno );
        Console.WriteLine("Name = "+name);
        Console.WriteLine("DOB = "+dob);

        Console.WriteLine("Type of Rollno = "+rollno.GetType());
        Console.WriteLine("Type of Name = "+name.GetType());
    }
}