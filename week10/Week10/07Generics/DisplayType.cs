using System;

namespace _07Generics
{
    // Non generic way
    public class DisplayType
    {
        public void DisplayTypeFor(Director d)
        {
            Console.WriteLine(d.GetType().FullName);
        }

        public void DisplayTypeFor(Student d)
        {
            Console.WriteLine(d.GetType().FullName);
        }

        public void DisplayTypeFor(Professor d)
        {
            Console.WriteLine(d.GetType().FullName);
        }
    }
}
