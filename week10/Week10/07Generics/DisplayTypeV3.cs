using System;

namespace _07Generics
{
    // Generic way, at method level
    public class DisplayTypeV3
    {
        public void DisplayTypeFor<MyType>(MyType obj)
        {
            Console.WriteLine(obj.GetType().FullName);
        }
    }
}
