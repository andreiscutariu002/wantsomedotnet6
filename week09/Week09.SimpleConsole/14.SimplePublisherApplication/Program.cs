using _14.SimplePublisherApplication.Implementations;
using _14.SimplePublisherApplication.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using _14.SimplePublisherApplication.Entities;

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

            IPublisherManager publisherManager = new PublisherManager(connectionString);

            int result = publisherManager.Create(
                new Publisher
                {
                    PublisherId = 2,
                    Name = "Vasile"
                }
            );

            Publisher publisher = publisherManager.Read(2);
        }
    }
}
