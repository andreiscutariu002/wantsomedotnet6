using _01AdoNetSimpleProject.Entities;
using _01AdoNetSimpleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _01AdoNetSimpleProject.Implementations
{

    public class DatabasePublisherManager : IPublisherManager
    {
        private readonly string connectionString;

        public DatabasePublisherManager(string connectionString)
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
                        // return null; // not so good

                        throw new InvalidOperationException($"Publisher with id: {id} does not exist!");
                    }
                }
            }
        }

        public int Update(Publisher publisher)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var commandText = $"update Publisher set Name = @nameParam where PublisherId = @idParam";

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

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Publisher> GetPublishersWhereNameIsLike(string value)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var commandText = "select * from Publisher where Name like @nameParam";
                var nameParam = new SqlParameter("nameParam", $"%{value}%");
                var command = new SqlCommand(commandText);

                command.Parameters.Add(nameParam);
                command.Connection = connection;

                IList<Publisher> list = new List<Publisher>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var publisherId = reader[0];
                        var name = reader[1];

                        list.Add(new Publisher
                        {
                            PublisherId = int.Parse(publisherId.ToString()),
                            Name = name.ToString()
                        });
                    }
                }

                return list;
            }
        }
    }
}
