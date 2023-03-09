using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Day8_ADO_Demo;

class Program02
{
    static void Main(string[] args)
    {
        //Configuring the configuration to read setting from it
        IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        SqlConnection conn= new SqlConnection(config.GetConnectionString("myconn"));

        Console.Write("Enter Trainee Id = ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        SqlCommand cmd = new SqlCommand("sp_searchtrainees",conn);
        cmd.CommandType =CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id",id);

        conn.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        if(reader.HasRows)
        {
            Console.WriteLine("Trainee Record Found");
            reader.Read();
            Console.WriteLine($"Id = {reader[0]}, FirstName = {reader[1]}, LastName={reader[2]}");
        }
        else
        {
            Console.WriteLine($"Trainee with id {id} not found");
        }

        reader.Close();
        conn.Close();
    }
}