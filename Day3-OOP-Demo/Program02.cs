using System;

namespace Day3_OOP_Demo;

class Program02
{
    void Sum(int x,int y)
    {
        Console.WriteLine("Sum = "+(x+y));
    }

    void Sum(int x,int y,int z)
    {
        Console.WriteLine("Sum = "+(x+y+z));
    }

    void Sum(double x,double y)
    {
        Console.WriteLine("Sum = "+(x+y));
    }

    // void Sum (double x,double y,out double z)
    // {
    //     z=x+y;
    // }

    // void Sum (double x,double y,double z)
    // {
    //     z=x+y;
    // }

    static void Main(string[] args)
    {
        Program02 p = new Program02();

        p.Sum(10,2);
        p.Sum(10,9,888);
        p.Sum(9.88888,17.9820982);
    }
}