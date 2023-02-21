using System;

namespace Day2_Demo;

class Program04
{
    static void Main(string[] args)
    {
        //Using for loop to print multiplication table of a given number 
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i=1;i<=10;i++)
        {
            Console.WriteLine($"{num} * {i} = {num*i}");
        }
    }
}