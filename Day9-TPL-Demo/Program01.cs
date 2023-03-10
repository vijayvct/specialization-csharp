using System.Threading.Tasks;
using System;

namespace Day9_TPL_Demo;

class Program01
{
    static void Main(string[] args)
    {
        //Creating and Executing a Simple Task usin Task.Run()

        // Task task =Task.Run(()=>{
        //     Task.Delay(5000);
        //     Console.WriteLine("Doing some task");
        // });

        // //task.Start();
        // task.Wait();

        Action action =new Action(()=>
        {
            Task.Delay(5000);
            Console.WriteLine("Doing some task....");
        });

        Task mytask =new Task(action);
        mytask.Start();

        mytask.Wait();
    }
}