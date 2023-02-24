using System;

namespace Day4_Inheritance_Demo;

//Single -Level Inheritance
class Employee //Base Class
{
    int id;
    string name;

    public void SetEmployee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    protected void GetEmployee()
    {
        Console.WriteLine($"Id = {id},Name ={name}");
    }
}

//Derived class
class Manager : Employee
{
    string department;
    int noofreportees;

    public void SetManager(string department, int noofreportees)
    {
        this.department = department;
        this.noofreportees = noofreportees;
    }

    public void GetManager()
    {
        GetEmployee();
        Console.WriteLine($"Department = {department},No of Reportees = {noofreportees}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager m1 = new Manager();

        m1.SetEmployee(999, "Malcolm");
        m1.SetManager("HR", 20);

        //m1.GetEmployee();
        m1.GetManager();
    }
}