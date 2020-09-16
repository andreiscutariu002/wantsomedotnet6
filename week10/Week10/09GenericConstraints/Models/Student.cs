using System;

namespace _09GenericConstraints
{
    public class Student : Human, IComparable
    {
        public string Name { get; set; }

        public string ClassNo { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
