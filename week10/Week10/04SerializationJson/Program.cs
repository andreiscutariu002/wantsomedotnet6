using _01AdoNetSimpleProject.Entities;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Json;

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

            // advanced
            JsonObject obj = new JsonObject();
            obj.Add("name", "Andrei");
            obj.Add("id", 20);

            var parsed = obj.TryGetValue("name", out var nameResult);
            var result = obj.ToString();
        }
    }
}
