using System;

namespace Day3_OOP_Demo;

partial class Student
{
    public Student(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public void ShowStudentInfo()
    {
        Console.WriteLine($"Id= {id},Name ={name}");
    }
}

class Program08
{
    static void Main(string[] args)
    {
        Student student = new Student(101, "Suresh");
        student.ShowStudentInfo();
    }
}