using System;

namespace Day4_Inheritance_Demo;

//Runtime Polymorphism Demo
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
}

class Circle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle......");
    }
}

class Square:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Square.......");
    }
}

class Cone:Shape
{
    public void Draw()
    {
        Console.WriteLine("Cone");
    }
}

class Program04
{
    static void Main(string[] args)
    {
        Shape shape=new Shape();
        shape.Draw();

        shape = new Circle();
        shape.Draw();

        shape = new Square();
        shape.Draw();

        shape = new Cone();
        shape.Draw();
    }
}