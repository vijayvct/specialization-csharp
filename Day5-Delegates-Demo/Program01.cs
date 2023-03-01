using System;

namespace Day5_Delegates_Demo;

//Delegate 
delegate bool IsPromotable(Employee employee);
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
    public double Salary { get; set; }

    public static void PromoteEmployees(List<Employee> employees,IsPromotable isPromotable)
    {
        foreach(Employee emp in employees)
        {
            if(isPromotable(emp))
            {
                Console.WriteLine(emp.Name +" is promoted...");
            }
        }
    }
}

class Program01
{
    public static bool CheckEligibility(Employee employee)
    {
        //if(employee.Salary>=4000)
        if(employee.Experience>5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        List<Employee> employees= new List<Employee>
        {
            new Employee{Id=1,Name="Malcolm",Experience=5,Salary=3500},
            new Employee{Id=2,Name="Bill",Experience=6,Salary=4500},
            new Employee{Id=3,Name="Scott",Experience=7,Salary=3500},
            new Employee{Id=4,Name="James",Experience=2,Salary=4000},
            new Employee{Id=5,Name="Julia",Experience=2,Salary=3500},
        };

        Employee.PromoteEmployees(employees,new IsPromotable(CheckEligibility));
    }
}