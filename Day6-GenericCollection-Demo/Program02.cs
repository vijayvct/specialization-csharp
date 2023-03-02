using System;
using System.Collections;
namespace Day6_GenericCollection_Demo;


class Program02
{
    static void Main(string[] args)
    {
        ArrayList alist =new ArrayList();

        Console.WriteLine($"Capacity = {alist.Capacity}, Count = {alist.Count}");

        //Adding Elements
        alist.Add(10);
        alist.Add(10.99);
        alist.Add(true);
        alist.Add("Hello User");
        alist.Add('Y');

        Console.WriteLine($"Capacity = {alist.Capacity}, Count = {alist.Count}");

        //Accessing element of the arraylist using index number
        Console.WriteLine("First Element = "+alist[0]);
        Console.WriteLine("Last Element = "+alist[alist.Count-1]);

        //iterate through the collection 
        foreach(var x in alist)
        {
            Console.Write(x+"\t");
        }

        Console.WriteLine();
    }
}