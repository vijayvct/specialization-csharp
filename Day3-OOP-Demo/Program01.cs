using System;

namespace Day3_OOP_Demo;

//Enum, Consttuctors and Constructor Overloading

enum Category
{
    General,
    Stationary,
    Computers
}

class Product :IDisposable
{
    int id;
    string name;
    double price;
    Category category;

    //Constructor
    public Product(int id,string name,double price,Category category)
    {
        this.id=id;
        this.name = name ;
        this.price=price;
        this.category= category;
    }

    public Product(int id,string name,double price)
    {
        this.id =id;
        this.name= name;
        this.price = price;
        category= Category.General;
    }

    public Product(int id,string name,Category category)
    {
        this.id = id;
        this.name = name ;
        this.category= category;
        price=5.00;
    }

    public void GetProductInfo()
    {
        Console.WriteLine($"Id = {id},Name = {name},Price = {price},Category = {category}");
    }

    public void Dispose()
    {
        //Logic to release the memory 

        GC.SuppressFinalize(this);

        Console.WriteLine("Object Disposed");
    }

    ~Product()
    {
        Console.WriteLine("\nDestructor Called...Object Destroyed");
    }
}

class Program01
{
    static void Main(string[] args)
    {
        Product p1=new Product(111,"Pen",9.99,Category.Stationary);
        p1.GetProductInfo();

        Product p2= new Product(123,"Notebook",199.99);
        p2.GetProductInfo();

        Product p3=new Product(888,"Eraser",Category.Stationary);
        p3.GetProductInfo();

        p1.Dispose();
        p2.Dispose();
        p3.Dispose();

        //GC.Collect();
    }
}