using System;

namespace Day9_Enhancement_Demo;

class Program02
{
    static void Main(string[] args)
    {
        //Dynamic Types 

        dynamic value1=13298;
        dynamic value2="Vijay Vishwakarma";
        dynamic value3=false;

        Console.WriteLine($"Value 1 = {value1} :- {value1.GetType()}");
        Console.WriteLine($"Value 2 = {value2} :- {value2.GetType()}");
        Console.WriteLine($"Value 3 = {value3} :- {value3.GetType()}");

        var data =100;

    }
}