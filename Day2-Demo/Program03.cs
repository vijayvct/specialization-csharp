using System;

namespace Day2_Demo;
class Program03
{
    static void Main(string[] args)
    {
        //Using Do-While loop to calculate factorial of a Number
        int fact=1,num;
        
        Console.WriteLine("Enter the number to calculate factorial");
        num = Convert.ToInt32(Console.ReadLine());

        do 
        {
            fact = fact *num;
            num--;
        }while(num>0);

        Console.WriteLine("Factorial = "+fact);
    }
}