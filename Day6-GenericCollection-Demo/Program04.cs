using System;
using System.Collections.Generic;

namespace Day6_GenericCollection_Demo;

class Program04
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();

        list.Add(new Employee{Id=101,Name="Vijay"});
        list.Add(new Employee{Id=102,Name="James"});
        list.Add(new Employee{Id=103,Name="Malcolm"});

        //Displat the details 
        foreach(var emp in list)
        {
            Console.WriteLine($"Id = {emp.Id},Name = {emp.Name}");
        }
    }
}