using Microsoft.Extensions.Configuration;
using System;

namespace _12.LoadConfigFromJson
{
    class Program
    {
        static void Main(string[] args)
        {
            // nu e ok sa fie hardcoded
            // var connectionString = @"Server=.;Database=week09;Trusted_Connection=True;";

            // - pasul 1
            // - trebuie sa instalam pachetele nuget
            // - acces la fisiere de configurari
            // Microsoft.Extensions.Configuration
            // Microsoft.Extensions.Configuration.FileExtensions
            // Microsoft.Extensions.Configuration.Json

            // - pasul 2
            // - creez un fisier nou appsettings.json

            // - pasul 3
            // - setez fisierul appsettings.json sa se copieze in folderul de output, la compliare
            // - click dreapta -> properties -> Copy to output directory: Copy always

            // - pasul 4
            // - citesc configurarile

            IConfiguration config = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", true, true)
                  .Build();

            var connectionString = config["ConnectionString"];

            Console.WriteLine(connectionString);

            Console.ReadKey();
        }
    }
}
