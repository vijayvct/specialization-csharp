using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Day9_TPL_Demo;

class Program08
{
    private static void ProcessData(int num)
    {
        Console.WriteLine(num*100);
    }
    static void Main(string[] args)
    {
        var nums = Enumerable.Range(0,1000000).ToArray();

        Partitioner<int> customPartinitoner = Partitioner.Create(nums,true);

        var query = from x in customPartinitoner.AsParallel()
                    select x;

        query.ForAll((data)=>{
            ProcessData(data);
        }) ;
    }
}