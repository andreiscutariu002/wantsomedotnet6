using _01AdoNetSimpleProject.Entities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace _04SerializationJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher
            {
                PublisherId = 1,
                Name = "Andrei"
            };

            var json = JsonConvert.SerializeObject(publisher);
            File.WriteAllText("output2.json", json);
        }
    }
}
