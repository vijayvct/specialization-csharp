using System;
using System.Collections;
using System.Text;

namespace Day5_Exception_Demo;

class Program03
{
    static bool Validate(Product product)
    {
        bool status= true;
        StringBuilder builder = new StringBuilder();

        if(product.Id<=0)
        {
            status = false;
            builder.Append("\nId cannot be zero or negative");
        }

        if(product.Name =="")
        {
            status=false;
            builder.Append("\nName cannot be blank");
        }

        if(product.Price<=0)
        {
            status = false;
            builder.Append("\nPrice cannot be zero or negative");
        }

        if(!status)
            throw new MyException(builder.ToString());

        return status;
    }
    static void Main(string[] args)
    {
        try
        {
            Product p = new Product();
            Console.WriteLine("Enter Product Id ");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name ");
            p.Name = Console.ReadLine();

            Console.WriteLine("Enter Product Price ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            if(Validate(p))
            {
                Console.WriteLine("Valid Object");
            }
        }
        catch(MyException ex)
        {
            Console.WriteLine("Error Message = "+ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error Message = "+ex.Message);
        }
    }
}