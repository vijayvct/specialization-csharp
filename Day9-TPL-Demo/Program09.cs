using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace Day9_TPL_Demo;

class OrderableListPartitioner<TSource> : OrderablePartitioner<TSource>
{
    private readonly IList<TSource> m_input;
    public OrderableListPartitioner(IList<TSource> input) : base(true, false, true)
    {
        m_input = input;
    }
    // Must override to return true.
    public override bool SupportsDynamicPartitions
    {
        get
        {
            return true;
        }
    }


    public override IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount)
    { 
        //Create a List of Partitions
        var dynamicPartitions = GetOrderableDynamicPartitions();
        var partitions = new IEnumerator<KeyValuePair<long,TSource>>[partitionCount];
        for (int i = 0; i < partitionCount; i++)
        { 
            //Iterate through the Partitions and process them  
            partitions[i] = dynamicPartitions.GetEnumerator();
        }
        return partitions;
    }
    public override IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
    {
        return new ListDynamicPartitions(m_input);
    }

private class ListDynamicPartitions : IEnumerable<KeyValuePair<long, TSource>>
{
    private IList<TSource> m_input; private int m_pos = 0;
    internal ListDynamicPartitions(IList<TSource> input)
    {
        m_input = input;
    }
    public IEnumerator<KeyValuePair<long, TSource>> GetEnumerator()
    {
        while (true)
        {
            // Each task gets the next item in the list. The index is
            // incremented in a thread-safe manner to avoid races.  
            int elemIndex = Interlocked.Increment(ref m_pos) - 1;  
            
            if (elemIndex >= m_input.Count)
            {
                yield break;
            }
            yield return new KeyValuePair<long, TSource>(elemIndex, m_input[elemIndex]);
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    { //Return Partitions one by one
        return ((IEnumerable<KeyValuePair<long, TSource>>)this).GetEnumerator();
    }
} }
class Program09
{
    static void Main()
    {
        var nums = Enumerable.Range(0, 10000).ToArray(); 
        OrderableListPartitioner<int> partitioner = new
        OrderableListPartitioner<int>(nums);
        // Use with Parallel.ForEach
        Parallel.ForEach(partitioner, (i) =>
        Console.WriteLine(i));
        //Use the AsParallel() function to execute the query //in Parallel using the above created Partitions
        var query = from num in partitioner.AsParallel()
                    where num % 2 == 0
                    select num;
        foreach (var v in query)
        {
            Console.WriteLine(v);
        }
    }
}
