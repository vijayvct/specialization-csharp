using System;
using System.Threading.Tasks;

namespace Day9_TPL_Demo;

class Program03
{
    static void Main(string[] args)
    {
        var func = new Func<int,int>((n)=>
        {
            int total =0;

            for(int i=0;i<n;i++)
            {
                Task.Delay(5000);
                total+=(int)Math.Pow(i,2);
                Console.WriteLine($"{total}");
            }

            return total;
        });

        Task<int> myTask1=new Task<int>(()=>{return func(500);});

        Task<int> myTask2=
                    myTask1.ContinueWith((myTask)=>{
                        return (int)Math.Sqrt(myTask.Result);
                    },TaskContinuationOptions.OnlyOnRanToCompletion);

        myTask1.Start();

        Task.WaitAll(myTask1,myTask2);

        Console.WriteLine($"First Result = {myTask1.Result}");
        Console.WriteLine($"Second Result = {myTask2.Result}");
    }
}