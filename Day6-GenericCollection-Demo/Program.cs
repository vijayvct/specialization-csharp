namespace Day6_GenericCollection_Demo;

//Generic Class 
class Numbers<T,U>
{
    T x;
    U y;

    public void SetValues(T x ,U y)
    {
        this.x=x;
        this.y=y;
    }

    public void GetValues()
    {
        Console.WriteLine($"X = {x},Y = {y}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Numbers<byte,long> num1= new Numbers<byte, long>();

        num1.SetValues(255,1098049840980984);
        num1.GetValues();

        Numbers<int,float> num2=new Numbers<int, float>();

        num2.SetValues(101,99.99F);
        num2.GetValues();
    }
}
