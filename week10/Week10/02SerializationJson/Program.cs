using _01AdoNetSimpleProject.Entities;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _02SerializationJson
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

            string fpath = @"output.data";
            Stream stream = File.Open(fpath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, publisher);
            stream.Close();
        }
    }
}
