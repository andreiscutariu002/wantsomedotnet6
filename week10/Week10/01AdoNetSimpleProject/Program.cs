using _01AdoNetSimpleProject.Entities;
using _01AdoNetSimpleProject.Implementations;
using _01AdoNetSimpleProject.Interfaces;
using Microsoft.Extensions.Configuration;
using System;

namespace _01AdoNetSimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();

            var connectionString = config["ConnectionString"];

            //IPublisherManager publisherManager = new DatabasePublisherManager(connectionString);
            IPublisherManager publisherManager = new FilePublisherManager("file.json");

            //int result = publisherManager.Create(
            //    new Publisher
            //    {
            //        PublisherId = 3,
            //        Name = "Dan"
            //    }
            //);

            Publisher publisher = publisherManager.Read(3);

            //var list = publisherManager.GetPublishersWhereNameIsLike("dan");

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}
