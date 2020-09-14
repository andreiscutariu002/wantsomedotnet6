using _14.SimplePublisherApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _14.SimplePublisherApplication.Interfaces
{
    public interface IPublisherManager
    {
        int Create(Publisher publisher);

        Publisher Read(int id);

        int Update(Publisher publisher);

        int Delete(int id);

        IList<Publisher> GetPublishersWhereNameIsLike(string value);
    }
}
