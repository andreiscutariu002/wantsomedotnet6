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
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var commandText = "select * from Publisher where PublisherId = @idParam";
                var idParam = new SqlParameter("idParam", id);
                var command = new SqlCommand(commandText);
                command.Parameters.Add(idParam);

                command.Connection = connection;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        var publisherId = reader[0];
                        var name = reader[1];

                        return new Publisher
                        {
                            PublisherId = int.Parse(publisherId.ToString()),
                            Name = name.ToString()
                        };
                    }
                    else
                    {
                    }
                }
            }

            return new Publisher();
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
