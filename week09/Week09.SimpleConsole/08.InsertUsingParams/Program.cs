using System;
using System.Data.SqlClient;

namespace _08.InsertUsingParams
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

                    var commandText = $"insert into Publisher values (@idParam, @nameParam)"; // avoid += concatenation
                    var command = new SqlCommand(commandText);

                    var idParamObject = new SqlParameter("idParam", id);
                    var nameParamObject = new SqlParameter("nameParam", name);

                    command.Parameters.Add(idParamObject);
                    command.Parameters.Add(nameParamObject);

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
