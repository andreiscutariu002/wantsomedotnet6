using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.LoadConfigOnNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            // - pe dot net framwork, pachetele de citit configurari sunt deja incluse in proiect 
            // - citim configurari direct din ConfigurationManager.AppSettings

            var connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            Console.WriteLine(connectionString);

            Console.ReadKey();
        }
    }
}
