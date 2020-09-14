using _14.SimplePublisherApplication.Entities;
using _14.SimplePublisherApplication.Interfaces;
using System;
using System.Data.SqlClient;

namespace _14.SimplePublisherApplication.Implementations
{
    public class PublisherManager : IPublisherManager
    {
        private readonly string connectionString;

        public PublisherManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(Publisher publisher)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var commandText = $"insert into Publisher values (@idParam, @nameParam)";

                var idParam = new SqlParameter("idParam", publisher.PublisherId);
                var nameParam = new SqlParameter("nameParam", publisher.Name);

                var command = new SqlCommand(commandText);

                command.Parameters.Add(idParam);
                command.Parameters.Add(nameParam);

                command.Connection = connection;

                var result = command.ExecuteNonQuery();

                return result;
            }
        }

        public Publisher Read(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
