using System.Threading;
using System.Threading.Tasks;
using System;
namespace Day9_TPL_Demo;
class Program
{
    static void RunMillionItreations()
    {
        string x="";
        for(int index=0;index<1000000;index++)
        {
            x=x+"s";
        }

      
    }

    static void Main(string[] args)
    {
    //    Thread t1=new Thread(RunMillionItreations);

    //    t1.Start();

       Parallel.For(0,1000000,x=>RunMillionItreations());

       Console.ReadLine();
    }
}
