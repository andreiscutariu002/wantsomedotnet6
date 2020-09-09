using System;
using System.Data.SqlClient;

namespace _07.InsertSqlInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;Database=week09;Trusted_Connection=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    var id = int.Parse(Console.ReadLine());
                    var name = Console.ReadLine();

                    // here we can have sql injection
                    // caused by += concatenation to create a query
                    var commandText = $"insert into Publisher values ({id}, {name})";
                    var command = new SqlCommand(commandText);

                    command.Connection = connection;

                    var result = command.ExecuteNonQuery();
                    Console.WriteLine($"Response: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
