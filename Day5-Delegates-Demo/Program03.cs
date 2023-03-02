using System;

namespace Day5_Delegates_Demo;

//Delegate
delegate void CollectionDelegate();

//Publisher
class MyCollection 
{
    //Event 
    public event CollectionDelegate ElementAdded;
    private List<string> list = new List<string>();

    public void Add(string value)
    {
        list.Add(value);
        ElementAddedNotification();
    }

    public void DisplayValues()
    {
        foreach(var item in list)
        {
            Console.Write(item +"\t");
        }
        Console.WriteLine();
    }
    private void ElementAddedNotification()
    {
        //Checking if Event is subscribed or not 
        if(ElementAdded!=null)
            ElementAdded();//Raising Event
    }
}

//Subscriber or Client
class Program03
{
    public static void PrintNotification()
    {
        Console.WriteLine("Element Added in the Collection");
    }
    
    static void Main(string[] args)
    {
        MyCollection collection=new MyCollection();

        //Subscribing the event
        collection.ElementAdded +=new CollectionDelegate(Program03.PrintNotification);

        collection.Add("Value1");
        collection.Add("Value2");
        collection.Add("Value3");

        collection.DisplayValues();
    }
}