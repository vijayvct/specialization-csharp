using System;

namespace Day2_Demo;

class Program
{
    static void Main(string[] args)
    {
        //Simple Example of If-Else Statement 
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if( (num>0) && (num%2==0))
        {
            Console.WriteLine("Valid Number");
        }
        else 
        {
            Console.WriteLine("Invalid Number");
        }
    }
}