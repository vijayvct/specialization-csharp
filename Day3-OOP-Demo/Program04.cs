using System;

namespace Day3_OOP_Demo;

//Auto-Implemented Property
class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public long Contact { get; set; }
    public string City { get; private set; }

    public Customer(string city)
    {
        City = city;
    }
}

class Program04
{
    static void Main(string[] args)
    {
        //Using Object Initializer Syntax to initialize object 
        Customer cust = new Customer("Mumbai")
        {
            ID=101,
            Name="James",
            Contact=320483209,
            //City="Mumbai"
        };

        Console.WriteLine("Customer Information");
        Console.WriteLine($"Id = {cust.ID}");
        Console.WriteLine($"Name = {cust.Name}");
        Console.WriteLine($"Contact No = {cust.Contact}");
        Console.WriteLine($"City = {cust.City}");
    }
}