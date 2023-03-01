namespace Day5_Delegates_Demo;

//Delegate Declaration
delegate void MyDelegate();

delegate void MyDelegate1(string message);

class Program
{
    //Delegate Method Declaration
    static void Display()
    {
        Console.WriteLine("Display () Called.....");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    static void Main(string[] args)
    {
       //Initalizing the Delegate 
       MyDelegate d1=new MyDelegate(Program.Display);

       MyDelegate1 d2= new MyDelegate1(Program.ShowMessage);

       //Invoking the method through delegate
       d1();

       d2("Welcome to Delegate");
       d2.Invoke("Good day user");
    }
}
