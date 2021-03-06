﻿using System;
using System.Data.SqlClient;

namespace _02.ExecuteScalar
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;Database=week09;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            // un sql connection - o instructiune catre DB

            // 3 moduri de interactiune cu DB-ul

                // 1 - Query [citesti date] - astepti o lista ca raspuns 
                // 2 - Non Query [scriu data] - trimit ceva la DB, nu astept raspuns
                // 3 - Execute Scalar - trimit o comanda, astept un raspuns, ca un singur obiect
                    // Returns a maximum of 2033 characters

            var commandText = "select count(*) from Publisher";
            var command = new SqlCommand(commandText);

            command.Connection = connection;

            var result = command.ExecuteScalar(); // modul 3
            Console.WriteLine($"Response: {result}");
        }
    }
}
