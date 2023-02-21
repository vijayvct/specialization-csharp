using System;

namespace Day1_Demo;

class Program03
{
    static void Main(string[] args)
    {
        //Nullable Type Demo 
        string name ="Malcolm";

        //DateTime? doj= DateTime.Now;
        Nullable<DateTime> doj=DateTime.Now;

        Console.WriteLine($"Name = {name}");

        if(doj.HasValue)
        {
            Console.WriteLine($"Date of Joining = {doj}");
        }
        else
        {
            Console.WriteLine("DOJ is not present");
        }
    }
}