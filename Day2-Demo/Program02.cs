using System;

namespace Day2_Demo;

class Program02
{
    static void Main(string[] args)
    {
        //Using While to calculate the sum of first 10 number 
        int sum =0, num=1;

        while(num==10)
        {
            sum = sum +num;
            num++;
        }

        Console.WriteLine("Sum = "+sum);
    }
}