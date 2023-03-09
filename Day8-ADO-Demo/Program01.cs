using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Day8_ADO_Demo;

class Program01
{
    static void Main(string[] args)
    {
        //Configuring the configuration to read setting from it
        IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        //Console.WriteLine(config.GetConnectionString("myconn"));
        //Adding new Trainee in the database 

        SqlConnection conn=new SqlConnection(config.GetConnectionString("myconn"));

        //Accept the input from the user
        Console.Write("Enter First Name = ");
        string fname=Console.ReadLine();

        Console.Write("\nEnter Last Name = ");
        string lname=Console.ReadLine();

        // Console.Write("\nEnter DOB = ");
        // DateTime dob = Convert.ToDateTime(Console.ReadLine());

        SqlCommand cmd =conn.CreateCommand();
        //cmd.CommandText="insert into Trainees(firstname,lastname) values ('"+fname+"','"+lname+"')";
        cmd.CommandText="insert into Trainees(firstname,lastname) values(@firstname,@lastname)";
        cmd.Parameters.AddWithValue("@firstname",fname);
        cmd.Parameters.AddWithValue("@lastname",lname);

        conn.Open();

        //Execute the insert query and return the number of rows affected
        int count = cmd.ExecuteNonQuery();

        if(count>0)
            Console.WriteLine("\nRecord Added Sucessfully...");
        else
            Console.WriteLine("\nUnable to Add Record");

        conn.Close();
    }
}