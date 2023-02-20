using System;

namespace Day1_Demo;

class Program01
{
    static void Main(string[] args)
    {
        //Creating and assigning values to variables
        int id =1001;
        string name="James";
        bool mstatus = false;

        Console.WriteLine("Id = "+id);
        Console.WriteLine("Name = "+name);
        Console.WriteLine("Martial Status = "+((mstatus)?"Married":"Unmarried"));
    }
}