using System;
using System.Data.SqlClient;

namespace _05.GoodWayV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;Database=week09;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            try
            {
                var commandText = "insert into Publisher values (5, 'Adrian')";
                // new connection is "created" [new connection is used from connection pool]
                var command = new SqlCommand(commandText);

                command.Connection = connection;

                var result = command.ExecuteNonQuery();
                Console.WriteLine($"Response: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close(); // this connection is closed
            }
        }
    }
}
