using System;

namespace Day9_Enhancement_Demo;

class Program01
{

    static void SetObject(object o){}

    static void Main(string[] args)
    {
        //Assignment Compatibility 
        string name = "James";
        //An object of more derived type is assigned to an object of a less derived type
        object obj = name;

        //Co-variance 
        IEnumerable<string> cities = new List<string>();

        IEnumerable<object> objects=cities;

        //Contra-variance
        Action<object> actionObject=SetObject;

        Action<string> actionString = actionObject;
    }
}