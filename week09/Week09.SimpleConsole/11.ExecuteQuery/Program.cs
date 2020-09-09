using System;
using System.Data;
using System.Data.SqlClient;

namespace _11.ExecuteQuery
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
                    var commandText = $"select publisherid, name from Publisher";
                    var command = new SqlCommand(commandText);

                    command.Connection = connection;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader[0];
                            var name = reader[1];

                            Console.WriteLine($"{id}, {name}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
