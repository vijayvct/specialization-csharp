using System;

namespace Day1_Demo;

class Program02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter age ");
        int age = Convert.ToInt32(Console.ReadLine());

        //Using Concatenation 
        Console.WriteLine("Name = "+name+", Age = "+age);

        //Using Placeholder 
        Console.WriteLine("Name = {0}, Age = {1}",name,age);

        //Using String Interpolation 
        Console.WriteLine($"Name = {name}, Age = {age}");
    }
}