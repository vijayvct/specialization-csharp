using System.Data.SqlClient;

namespace Day8_ADO_Demo;
class Program
{
    static void Main(string[] args)
    {
        //Creating a SqlConnection object and specifying ConnectionString 
        SqlConnection conn=new SqlConnection();
        conn.ConnectionString="data source=CTAADPG02MWBG;initial catalog=demodb;user id=sa;password=Password_123";

        //Create a SqlCommand object and specify the select query 
        SqlCommand cmd =new SqlCommand();
        cmd.Connection= conn;
        cmd.CommandText="select * from Trainee";

        //Open Connection 
        conn.Open();

        //Execute the reader and read the data
        SqlDataReader reader=cmd.ExecuteReader();

        if(reader.HasRows)
        {
            while(reader.Read())
            {
                Console.WriteLine($"Id ={reader[0]}, FirstName = {reader[1]}, LastName = {reader[2]}, DOB = {reader[3]} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No Records to read");
        }

        //Close reader and connection 
        reader.Close();
        conn.Close();
    }
}
