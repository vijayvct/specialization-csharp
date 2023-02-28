using System;

namespace Day4_Inheritance_Demo;

//Constructors in Inheritance

class Base
{
    public Base()
    {
        Console.WriteLine("Base class constructor called");
    }

    public void Show()
    {
        Console.WriteLine("Show from the base class");
    }
}

class Derived:Base
{
    public Derived()
    {
        Console.WriteLine("Derived class Constructor called");
    }

    public void Display()
    {
        Console.WriteLine("Display from the child class");
    }

    //Method Hiding 
    public new void Show()
    {
        base.Show();
        Console.WriteLine("Show from the Derived class");
    }
}

class Program02
{
    static void Main(string[] args)
    {
        Derived derived=new Derived();
        derived.Show();
        derived.Display();

        // Base obj = new Derived();
        // obj.Show();
    }
}