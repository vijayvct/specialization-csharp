using System;

namespace Day4_Inheritance_Demo;

//Abstract class 
abstract class Animal
{
    string name;

    //Constructor 
    public Animal(string name)
    {
        this.name = name;
    }

    //Concrete Method 
    public void Habitat()
    {
        Console.WriteLine("Habitat() from the Animal Class");
    }

    //Virtual Method

    public virtual void Food()
    {
        Console.WriteLine("Every animal eats food to survive");
    }

    //Abstract Method 
    public abstract void Sound();

    //Property 
    public string Name{
        get {
            return name;
        }
    }
}

class Cat:Animal
{
    public Cat(string name):base(name){}

    public override void Food()
    {
        Console.WriteLine("Loves to eat Mice.......");
    }

    public override void Sound()
    {
        Console.WriteLine("Cat Meows.....");
    }
}

class Program05
{
    static void Main(string[] args)
    {
        //Animal cat = new Animal("Tom");
        Cat cat = new Cat("TOM");
        Console.WriteLine($"Name = {cat.Name}");
        cat.Habitat();
        cat.Food();
        cat.Sound();
    }
}