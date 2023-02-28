using System;

namespace Day4_Inheritance_Demo;

//Multi-Level Inheritance 

class Television 
{
    public void Sound()
    {
        Console.WriteLine("Sound() from the Television Class");
    }
}

class LEDTV:Television
{
    public void Display()
    {
        Console.WriteLine("Display() from the LEDTV Class");
    }
}

sealed class SmartTV:LEDTV
{
    public void Features()
    {
        Console.WriteLine("Features() from the SmartTV Class");
    }
}

//The below lines will give compile-time error as we are trying to inherit a sealed class
// class QLEDTV:SmartTV
// {

// }

class Program01
{
    static void Main(string[] args)
    {
        SmartTV tv = new SmartTV();

        tv.Sound();
        tv.Display();
        tv.Features();
    }
}