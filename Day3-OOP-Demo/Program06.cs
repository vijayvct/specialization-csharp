using System;

namespace Day3_OOP_Demo;

class Orders
{
    //Non-Static Data Member 
    int id;
    string name;

    //Static Data-Member 
    static int OrderCount;

    //Static Constructor 
    static Orders()
    {
        Console.WriteLine("Static Constructor is called....");
        OrderCount = 0;
    }

    //Non-Static Constructor 
    public Orders(int id, string name)
    {
        this.id = id;
        this.name = name;

        OrderCount += 1;
    }

    //Static Method 
    public static void ShowOrderCount()
    {
        Console.WriteLine("No of Orders Placed = " + OrderCount);
    }
}

class Program06
{
    static void Main(string[] args)
    {
        Orders o1 = new Orders(101, "James");
        Orders o2 = new Orders(102, "Julia");

        Orders.ShowOrderCount();
    }
}

