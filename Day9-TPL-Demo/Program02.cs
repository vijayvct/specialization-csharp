using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day9_TPL_Demo;

class Program02
{
    static void Main(string[] args)
    {
        CancellationToken token = new CancellationTokenSource().Token;  
        
        Task t1=Task.Factory.StartNew((state) =>
        {
            int limit = (int)state;
            
            for (int i = 0; i < limit; i++)
            {
                Console.Write(i + 1 +"\t");
            }
        },11,token,TaskCreationOptions.LongRunning,TaskScheduler.Current);

        t1.Wait();
    }
}