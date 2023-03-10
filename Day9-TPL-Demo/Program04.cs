using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day9_TPL_Demo;

class Program04
{
    private static int Fibinacci(int n,CancellationToken token)
    {
        int a=0,b=1;

        for(int i=0;i<n;i++)
        {
            if(token.IsCancellationRequested)
            {
                Console.WriteLine("Getting out of the Fibonnaci Sequence.......");

                return a;
            }

            int temp =a;
            a=b;
            b=temp+b;

            Console.WriteLine($"Current result = {a}");
        }
        return a;
    }

    static void Main(string[] args)
    {
        ConsoleKeyInfo input;

        CancellationTokenSource cancellationTokenSource=new CancellationTokenSource();

        CancellationToken token = cancellationTokenSource.Token;

        Task<int> myFibonnaciTask = null;

        myFibonnaciTask = new Task<int>(()=>
        {
            return Fibinacci(5000,token);
        },token);

        myFibonnaciTask.Start();

        do
        {
            while(!Console.KeyAvailable)
            {
                if(myFibonnaciTask.IsCompleted)
                {
                    goto End;
                }
            }

            input = Console.ReadKey(true);

            if(!myFibonnaciTask.IsCompleted & !cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Cancel();

                Console.WriteLine("Cancelled");
            }
        }while(input.Key!=ConsoleKey.Escape);

End:
    Console.WriteLine($"Result {myFibonnaciTask.Result}");
    Console.WriteLine("Program has ended......");
    Console.ReadKey();
    }
}