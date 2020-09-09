using System;
using System.Data.SqlClient;

namespace _04.BadWay
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;Database=week09;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            var commandText = "insert into Publisher values (5, 'Adrian')";
            // new connection is "created" [new connection is used from connection pool]
            var command = new SqlCommand(commandText); 

            command.Connection = connection;

            var result = command.ExecuteNonQuery();
            Console.WriteLine($"Response: {result}");

            // this connection needs to be closed

            connection.Close(); // this connection is closed
        }
    }
}
