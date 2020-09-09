using System;
using System.Data.SqlClient;

namespace _01.SimpleConsole
{
    // method to connect to database
    class Program
    {
        static void Main(string[] args)
        {
            // un server name [ip]
            // un database name
            // detalii de autentificare
                // user & password
                // windows authentifiation [Trusted_Connection]
            
            var connectionString = @"Server=.;Database=week09;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();  
            } catch (Exception e)
            {
                //

                Console.WriteLine(e.Message);
            }
        }
    }
}
