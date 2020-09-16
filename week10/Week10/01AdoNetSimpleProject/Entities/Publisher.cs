using System;
using System.Collections.Generic;
using System.Text;

namespace _01AdoNetSimpleProject.Entities
{
    [Serializable()]
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }
    }
}
