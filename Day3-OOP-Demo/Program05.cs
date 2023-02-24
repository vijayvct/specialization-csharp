using System;

namespace Day3_OOP_Demo;

class Sample
{
    int [] numbers;

    public Sample(int size)
    {
        numbers= new int[size];
    }

    //Indexer
    public int this[int index]
    {
        get
        {
            return numbers[index];
        }

        set 
        {
            numbers[index]=value;
        }
    }
}

class Program05
{
    static void Main(string[] args)
    {
        Sample s=new Sample(5);
        int value=10;

        for (int i = 0; i < 5; i++)
        {
            s[i]=value;
            value+=10;
        }

        Console.WriteLine("First Element = "+s[0]);
    }
}