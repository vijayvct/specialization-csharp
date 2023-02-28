using System;

namespace Day4_Inheritance_Demo;

class Employees
{
    int id;
    string name;
    double salary;

    public Employees(int id,string name,double salary)
    {
        this.id= id;
        this.name= name;
        this.salary=salary;
    }

    public void GetEmployeeDetails()
    {
        Console.WriteLine($"Id = {id},Name = {name},Salary = {salary}");
    }

    public virtual double CalculateBonus()
    {
        return salary*0.10;
    }
}

class SalesExecutive:Employees
{
    bool targetAchieved;

    public SalesExecutive(int id,string name,double salary,bool targetStatus)
        :base(id,name,salary)
    {
        this.targetAchieved= targetStatus;
    }

    public void ShowTargetStatus()
    {
        Console.WriteLine("Target Stauts = "+((targetAchieved)?"Achieved":"Not Achieved"));
    }

    public override double CalculateBonus()
    {
        if(targetAchieved)
            return base.CalculateBonus()*2;
        else
            return base.CalculateBonus();
    }
}

class Program03
{
    static void Main(string[] args)
    {
        SalesExecutive executive1= new SalesExecutive(999,"James",9999,true);
        SalesExecutive executive2= new SalesExecutive(1920,"Julia",8766,false);

        executive1.GetEmployeeDetails();
        executive1.ShowTargetStatus();
        Console.WriteLine("Bonus Amount = "+executive1.CalculateBonus());

        Console.WriteLine();

        executive2.GetEmployeeDetails();
        executive2.ShowTargetStatus();
        Console.WriteLine("Bonus Amount = "+executive2.CalculateBonus());
    }
}