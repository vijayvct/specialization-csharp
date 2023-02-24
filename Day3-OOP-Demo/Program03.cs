using System;

namespace Day3_OOP_Demo;

//Properties 
class Order
{
    int id,quantity;
    double unitprice,discount;
    DateTime orderdate;

    //Properties 
    public int OrderId
    {
        get
        {
            return id;
        }

        set
        {
            id= value;
        }
    }

    public DateTime OrderDate
    {
        get
        {
            return orderdate;
        }

        set
        {
            orderdate= value;
        }
    }

    public double UnitPrice
    {
        get
        {
            return unitprice;
        }

        set 
        {
            if(value<0)
                unitprice=0;
            else
                unitprice=value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }

        set 
        {
            if (value<0)
                quantity=0;
            else
                quantity=value;
        }
    }

    //Write_only Property 
    public double Discount
    {
        set 
        {
            discount= value;
        }
    }

    //Read-Only Property 
    public double TotalPrice
    {
        get
        {
            var grossamount = quantity*unitprice;
            var discamount = grossamount -(grossamount*discount);
            return discamount;
        }
    }
}

class Program03
{
    static void Main(string[] args)
    {
        Order o1=new Order();
        o1.OrderId=10101;
        o1.OrderDate= DateTime.Now;
        o1.UnitPrice =-19.88;
        o1.Quantity=100;
        o1.Discount = 0.20;

        Console.WriteLine("Order Details");
        Console.WriteLine("Id = "+o1.OrderId);
        Console.WriteLine("Date = "+o1.OrderDate);
        Console.WriteLine("UnitPrice = "+o1.UnitPrice);
        Console.WriteLine("Qunatity = "+o1.Quantity);
        Console.WriteLine("Total Price = "+o1.TotalPrice);

        //o1.TotalPrice=99999;
        //Console.WriteLine("Discount = "+o1.Discount);
    }
}