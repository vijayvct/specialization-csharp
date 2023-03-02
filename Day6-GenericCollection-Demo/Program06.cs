using System;
using System.Collections.Generic;

namespace Day6_GenericCollection_Demo;

class Program06
{
    static void Main(string[] args)
    {
        Dictionary<int,string> emplist = new Dictionary<int, string>();

        emplist.Add(101,"Julia");
        emplist.Add(102,"Martha");
        emplist.Add(103,"Clark");

        Console.WriteLine ("First Employee = "+emplist[101]);

        foreach (var item in emplist)
        {
            Console.WriteLine($"{item.Key},{item.Value}");
        }
    }
}