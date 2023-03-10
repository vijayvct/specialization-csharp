namespace Day9_Enhancement_Demo;
class Program
{
    //Named and Optional Arguments
    static void CalculateSI(int pri,int years,double rate=0.15)
    {
        double result = (pri*years*rate)/100;

        Console.WriteLine($"Simple Interest = {result}");
    }

    static void Main(string[] args)
    {
        CalculateSI(1000,2,3.5);    

        //Calling function with optional arguments
        CalculateSI(2000,5);
        //Calling function with named argumments
        CalculateSI(rate:10.55,pri:40000,years:5);
    }
}   
