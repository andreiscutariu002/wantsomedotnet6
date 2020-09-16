using System;

namespace _07Generics
{
    // Generic way, at class level
    public class DisplayTypeV2<T>
    {
        public void DisplayTypeFor(T obj)
        {
            Console.WriteLine(obj.GetType().FullName);
        }
    }
}
