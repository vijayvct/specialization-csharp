using System;

namespace Day5_Exception_Demo;

class Program02
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if((num>0) && (num%5==0))
            {
                Console.WriteLine("Valid Number....");
            }
            else
            {
                throw new MyException("Number must be positive and divisible by 5");
            }
        }
        catch(MyException ex)
        {
            Console.WriteLine("Error Message = "+ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error Message = "+ex.Message);
        }
    }
}