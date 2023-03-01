using System;

namespace Day5_Exception_Demo;

//Multiple-Catch Block 

class Program01
{
    static void Main(string[] args)
    {
        try
        {
            //First Scenario
            Console.WriteLine("Enter First number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2=Convert.ToInt32(Console.ReadLine());

            int result = num1/num2;

            Console.WriteLine("Result = "+result);

            //Second Scenario 
            double [] numbers = {10.99,2.88,99.88};

            numbers[1]=199.99;

            //Third Scenario
            int [] newnumbers = new int[numbers.Length];

            Array.Copy(numbers,newnumbers,3);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("\nDivide By Zero Exception Caught");
            Console.WriteLine("Error Message = "+ex.Message);
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("\nIndex Out of Range Exception Caught");
            Console.WriteLine("Error Message = "+ex.Message);
        }
        catch(ArrayTypeMismatchException ex)
        {
            Console.WriteLine("\nArrayType Mismatch Exception Caught");
            Console.WriteLine("Error Message = "+ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Exception caught");
            Console.WriteLine("Error Message = "+ex.Message);
        }
    }
}