namespace Day3_OOP_Demo;

//Simple Example of Class and Object 

/// <summary>
/// An Employee class to demonstrate the use of OOPs Concept
/// </summary>
class Employee
{
    //Data Members
    int id;
    string name;

    //Member Functions 
    /// <summary>
    /// Method to set employee details
    /// </summary>
    /// <param name="id">Employee Id</param>
    /// <param name="name">Employee Name</param>
    public void SetEmployee(int id,string name)
    {
       this.id = id ;
       this.name= name;
    }

    /// <summary>
    /// Display's Employee Information
    /// </summary>
    public void GetEmployee()
    {
        Console.WriteLine($"Id = {id}, Name = {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1=new Employee();

        emp1.SetEmployee(101,"Malcolm");
        emp1.GetEmployee(); 

        Employee emp2=new Employee();

        emp2.SetEmployee(102,"James");
        emp2.GetEmployee();
    }
}
