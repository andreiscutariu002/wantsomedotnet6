using _01AdoNetSimpleProject.Entities;
using System;

namespace _06GenericsTypeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            Type type = publisher.GetType();
            var type2 = typeof(Publisher);

            //var type3 = typeof(publisher);

            PrintFullName(type);

            PrintFullName(type2);

            PrintFullName(typeof(string));
        }

        static void PrintFullName(Type t)
        {
            Console.WriteLine(t.FullName);
        }
    }
}
