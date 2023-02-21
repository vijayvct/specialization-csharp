using System;

namespace Day2_Demo;

class Program05
{
    static void Main(string[] args)
    {
        //Using Single-Dimensional Array 
        int [] numbers = {10,99,22,55,223,990,191};

        Console.WriteLine("No of Elements = "+numbers.Length);

        Console.WriteLine("First Element = "+numbers[0]);
        Console.WriteLine("Third Element = "+numbers[2]);

        foreach(int num in numbers)
        {
            Console.Write(num+"\t");
        }

        Console.WriteLine();

        Console.WriteLine("Sorted Array");
        
        Array.Sort(numbers);
        foreach(int num in numbers)
        {
            Console.Write(num+"\t");
        }

        Console.WriteLine();
    }
}