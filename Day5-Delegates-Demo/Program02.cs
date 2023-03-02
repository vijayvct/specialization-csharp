using System;

namespace Day5_Delegates_Demo;

//Multicast Delegate Demo 
delegate void ArithematicOperations(double x,double y);

class Program02
{
    static void Add(double x,double y)
    {
        Console.WriteLine("Sum = "+(x+y));
    }

    static void Subtract(double x,double y)
    {
        Console.WriteLine("Subtract = "+(x-y));
    }

    static void Multiply(double x,double y)
    {
          Console.WriteLine("Product = "+(x*y));
    }

    static void Main(string[] args)
    {
        ArithematicOperations d1= new ArithematicOperations(Program02.Add);

        d1+=new ArithematicOperations(Program02.Subtract);
        d1+=new ArithematicOperations(Program02.Multiply);

        d1(19,9);

        ArithematicOperations a1 = new ArithematicOperations(Program02.Multiply);
        ArithematicOperations a2= new ArithematicOperations(Program02.Subtract);

        ArithematicOperations a3= a1+a2;

        a3(100,2);
    }
}