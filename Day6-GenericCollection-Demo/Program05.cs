using System;
using System.Collections;

namespace Day6_GenericCollection_Demo;

class Program05
{
    static void Main(string[] args)
    {
        Hashtable currencies=new Hashtable();

        currencies.Add("INR","Indian Rupees");
        currencies.Add("USD","US Dollars");
        currencies.Add("GBP","Great Britan Pound");

        //Accessing values using keys
        Console.WriteLine(currencies["INR"]);

        Console.WriteLine("No of records = "+currencies.Count);

        if(currencies.ContainsKey("USD"))
        {
            currencies["USD"] ="United States Dollar";
        }
        else
        {
            currencies.Add("USD","United States Dollar");
        }

        foreach(DictionaryEntry de in currencies)
        {
            Console.WriteLine($"{de.Key},{de.Value}");
        }
    }
}