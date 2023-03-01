using System;

namespace Day5_Exception_Demo;

class MyException:Exception
{
    public MyException(){}

    public MyException(string message)
        :base(message)
    {
        
    }
}