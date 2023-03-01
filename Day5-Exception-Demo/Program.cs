namespace Day5_Exception_Demo;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Program Started......");

        try
        {
            int x=100,y=2,z;

            z=x/y;

            Console.WriteLine("Result = "+z);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Type of Exception = "+ex.GetType());
            Console.WriteLine("Error Message = "+ex.Message);
            Console.WriteLine("Source = "+ex.Source);
            Console.WriteLine("StackTrace = "+ex.StackTrace);
        }
        finally 
        {
            Console.WriteLine("\nHello from the Finally Block");
            //throw new Exception("Hello");
            Console.WriteLine("Finally Block will always execute");
        }

       Console.WriteLine("Program Exiting......");
    }
}
