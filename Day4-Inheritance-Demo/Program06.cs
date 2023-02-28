using System;

namespace Day4_Inheritance_Demo;

//Interface 
public interface IPrintStatement
{
    void PrintStatement();
}

//Classes 
class SavingAccount : IPrintStatement
{
    public void PrintStatement()
    {
        Console.WriteLine("Printing Saving Account Statement.......");
    }
}

class CurrentAccount : IPrintStatement
{
    public void PrintStatement()
    {
        Console.WriteLine("Printing Current Account Statement......");
    }
}

class Printer
{
    private IPrintStatement statement;

    public Printer(IPrintStatement statement)
    {
        this.statement=statement;
    }

    public void Print()
    {
        statement.PrintStatement();
    }
}

// class Printer
// {
//     SavingAccount savingAccount=new SavingAccount();
//     CurrentAccount currentAccount= new CurrentAccount();

//     public void Print()
//     {
//         savingAccount.PrintStatement();
//         currentAccount.PrintStatement();
//     }
// }

class Program06
{
    static void Main(string[] args)
    {
        // Printer p = new Printer();
        // p.Print();

        Printer p1=new Printer(new SavingAccount());
        Printer p2=new Printer(new CurrentAccount());

        p1.Print();
        p2.Print();
    }
}
