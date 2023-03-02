using System;
using System.Collections;

namespace Day6_GenericCollection_Demo;

class Program03
{
    static void Main(string[] args)
    {
        ArrayList emplist = new ArrayList();

        emplist.Add(new Employee{Id =101,Name="Malcolm"});
        emplist.Add(new Employee{Id =102,Name="James"});
        emplist.Add(new Employee{Id =103,Name="Scott"});        

        //Displaying the Employee Details 
        foreach(var emp in emplist)
        {
            Employee e = (Employee)emp;
            Console.WriteLine($"Id = {e.Id},Name ={e.Name}");
        }
    }
}