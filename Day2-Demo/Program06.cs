using System;

namespace Day2_Demo;

class Program06
{
    static void Main(string[] args)
    {
        double [,] scores ={
            {101,77.88},
            {102,99.77},
            {103,88.99}
        };

        Console.WriteLine("Total No of Elements ="+scores.Length);
        Console.WriteLine("Total No of Rows = "+scores.GetLength(0));
        Console.WriteLine("Total No of Colums = "+scores.GetLength(1));

        // foreach(double item in scores)
        // {
        //     Console.Write(item +"\t");
        // }
        // Console.WriteLine();

        //Using Nested For Loop to iterate over Array
        for(int i=0;i<scores.GetLength(0);i++)
        {
            for(int j=0;j<scores.GetLength(1);j++)
            {
                Console.Write(scores[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }
}