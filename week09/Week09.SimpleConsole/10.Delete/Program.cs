using System;
using System.Data.SqlClient;

namespace _10.Delete
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

                    var commandText = $"delete from Publisher where publisherid = @idParam"; // avoid += concatenation
                    var command = new SqlCommand(commandText);

                    var idParamObject = new SqlParameter("idParam", id);

                    command.Parameters.Add(idParamObject);

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
