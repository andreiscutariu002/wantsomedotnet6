using _14.SimplePublisherApplication.Implementations;
using _14.SimplePublisherApplication.Interfaces;
using Microsoft.Extensions.Configuration;
using System;

namespace _14.SimplePublisherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();

            var connectionString = config["ConnectionString"];

            Console.WriteLine(connectionString);

            IPublisherManager publisherManager = new PublisherManager();

            int result = publisherManager.Create(
                new Entities.Publisher
                {
                    PublisherId = 1,
                    Name = "Andrei"
                }
            );
        }
    }
}
