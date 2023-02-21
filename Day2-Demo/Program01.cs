using System;

namespace Day2_Demo;

class Program01
{
    static void Main(string[] args)
    {
        //Simple Example of Switch Case 
        DateTime date = DateTime.Now;

        switch(date.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("It is Monday");
                break;

            case DayOfWeek.Tuesday:
                Console.WriteLine("It is Tuesday");
                break;

            case DayOfWeek.Wednesday:
                Console.WriteLine("It is Wednesday");
                break;

            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("Its Weekend");
                break;
                
            default:
                Console.WriteLine("Some other day of the week");
                break;
        }
    }
}