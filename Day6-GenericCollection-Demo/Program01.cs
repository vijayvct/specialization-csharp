using System;

namespace  Day6_GenericCollection_Demo;

class Sample
{
    //Generic Method
    public static void Swap<T>(T x,T y)
    {
        T temp ;
        temp=x;
        x=y;
        y=temp;

        Console.WriteLine("Interchange Values");
        Console.WriteLine($"X = {x},Y = {y}");
    }

    public static void DisplayArray<T>(params T[] data) //where T : class
    {
        foreach(var item in data)
        {
            Console.Write(item +"\t");
        }
        Console.WriteLine();
    }
}

class Program01
{
    static void Main(string[] args)
    {
        Sample.Swap<int>(1000,99999);
        Sample.Swap<double>(19.99,188.999);
        Sample.Swap<string>("Bill","Gates");

        Console.WriteLine();

        Sample.DisplayArray(19,99,992,1000);
        Sample.DisplayArray<double>(19.99,2.33,3.11,4.55,9.111);
        Sample.DisplayArray<string>("Mumbai","Pune","Chennai","Hyderabad","Bengaluru");
    }
}