using System;

namespace Day3_OOP_Demo;

//Static Class, Constructor and Method
static class MyMath
{
    //Static Data Member 
    public static double PI = 3.14115;

    //Static Constructor
    static MyMath()
    {
        Console.WriteLine("Static Constructor Called....");
    }

    //Static Method 
    public static void DisplayMessage()
    {
        Console.WriteLine("Hello from a Static Method");
    }
}

class Program07
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine($"PI = {MyMath.PI}");
        MyMath.DisplayMessage();
    }
}

//Partial Class 
partial class Student
{
    int id;
    string name;
}