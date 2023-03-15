using System;
using System.Threading;
using System.Collections.Generic;

namespace Day9_TPL_Demo;

class Program06
{
    static Dictionary<int,string> dictionary= new Dictionary<int, string>();

    static void Method01()
    {
        for(int i=0;i<10;i++)
        {
            dictionary.Add(i,"Added by Method01 "+i);
            Thread.Sleep(100);
        }
    }

    static void Method02()
    {
        for(int i=0;i<10;i++)
        {
            dictionary.Add(i,"Added by Method02 "+i);
            Thread.Sleep(100);
        }
    }
    static void Main(string[] args)
    {
        Thread t1= new Thread(Method01);
        Thread t2= new Thread(Method02);

        t1.Start();
        t2.Start();
    }
}