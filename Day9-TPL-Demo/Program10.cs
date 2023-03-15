using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Day9_TPL_Demo;

//Demonstrate how to write and read from a dataflow block 
class Program10
{
    //Demonstrate asynchronous data flow operations
    static async Task AsyncSendReceive(BufferBlock<int> bufferBlock)
    {
        for(int i=0;i<3;i++)
        {
            await bufferBlock.SendAsync(i);
        }

        for(int i=0;i<3;i++)
        {
            Console.WriteLine(await bufferBlock.ReceiveAsync());
        }
    }

    static async Task Main(string [] args)
    {
        var bufferBlock = new BufferBlock<int>();

        //Post Several message to the block
        for(int i=0;i<3;i++)
        {
            bufferBlock.Post(i);
        }


        for(int i=0;i<3;i++)
        {
            Console.WriteLine(bufferBlock.Receive());
        }

        for(int i=0;i<3;i++)
        {
            bufferBlock.Post(i);
        }

        //Receive the message back from the block 
        while(bufferBlock.TryReceive(out int value))
        {
            Console.WriteLine(value);
        }

        //Writing and Reading from message block concurrently 
        var post01=Task.Run(()=>{
            bufferBlock.Post(0);
            bufferBlock.Post(1);
        });

        var receive = Task.Run(()=>{
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(bufferBlock.Receive());
            }
        });

        var post02=Task.Run(()=>{
            bufferBlock.Post(2);
        });        

        await Task.WhenAll(post01,receive,post02);

        await AsyncSendReceive(bufferBlock);
    }
}