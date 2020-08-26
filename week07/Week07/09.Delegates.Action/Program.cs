using System;

namespace _09.Delegates.Action
{
    using Action = System.Action;

    class Program
    {
        // Action is a delegate type defined in the System namespace. An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value. In other words, an Action delegate can be used with a method that has a void return type.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Action<string, int> m1 = Method1;

            Action<string, int, double> m2 = Method2;

            // inline 
            Action<string, int, double> inline = (s, i, arg3) =>
            {
                //...
            };

            Action<string, int, double> inlineV2 = delegate(string s, int i, double arg3)
            {
                //...
            };
        }

        static void Method1(string a, int b)
        {
        }

        static void Method2(string a, int b, double c)
        {
        }
    }
}
