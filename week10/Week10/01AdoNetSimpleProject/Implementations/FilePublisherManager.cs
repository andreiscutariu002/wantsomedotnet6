using _01AdoNetSimpleProject.Entities;
using _01AdoNetSimpleProject.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01AdoNetSimpleProject.Implementations
{
    public class FilePublisherManager : IPublisherManager
    {
        private readonly string fileName;

        private List<Publisher> publishers; 

        public int Create(Publisher publisher)
        {
            publishers.Add(publisher);

            var json = JsonConvert.SerializeObject(publishers);
            File.WriteAllText(fileName, json);

            return 1;
        }

        public Publisher Read(int id)
        {
            return publishers.FirstOrDefault(x=>x.PublisherId == id);
        }

        public int Update(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Publisher> GetPublishersWhereNameIsLike(string value)
        {
            throw new NotImplementedException();
        }

        public FilePublisherManager(string fileName)
        {
            this.fileName = fileName;

            string data = File.ReadAllText(fileName);

            this.publishers = JsonConvert.DeserializeObject<List<Publisher>>(data);
        }
    }
}
