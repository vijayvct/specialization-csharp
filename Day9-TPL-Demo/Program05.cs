using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Day9_TPL_Demo;

class Program05
{
    private static bool IsPrime(int number)
    {
        if(number<2)
        {
            return false;
        }

        for(var divisor=2;divisor <= Math.Sqrt(number);divisor++)
        {
            if(number%divisor==0)
            {
                return false;
            }
        }

        return true;
    }

    private static IList<int> GetPrimeList(IList<int> numbers)=> numbers.Where(IsPrime).ToList();

    private static IList<int> GetPrimeWithParallel(IList<int> numbers)
    {
        var primeNumbers = new ConcurrentBag<int>();

        Parallel.ForEach(numbers,number=>{
            if(IsPrime(number))
            {
                primeNumbers.Add(number);
            }
        });

        return primeNumbers.ToList();
    }

    static void Main(string[] args)
    {
        //Parallel For 
        // Parallel.For(0,10000,ctr=>{
        //     Console.WriteLine("Iteration = "+ctr);
        // });

        var limit = 2000000;
        var numbers = Enumerable.Range(0,limit).ToList();

        var watch = Stopwatch.StartNew();
        var primeNumbersForEach=GetPrimeList(numbers);
        watch.Stop();

        var watchforParallel=Stopwatch.StartNew();
        var primeNumbersForParallel= GetPrimeWithParallel(numbers);
        watchforParallel.Stop();

        Console.WriteLine("For Each Loop");
        Console.WriteLine($"Total Prime Numbers = {primeNumbersForEach.Count}");
        Console.WriteLine($"Time Taken = {watch.ElapsedMilliseconds} ms");


        Console.WriteLine("Parallel For Each Loop");
        Console.WriteLine($"Total Prime Numbers = {primeNumbersForParallel.Count}");
        Console.WriteLine($"Time Taken = {watchforParallel.ElapsedMilliseconds} ms");
    }
}