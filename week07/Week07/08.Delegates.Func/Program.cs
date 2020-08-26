using System;

namespace _08.Delegates.Func
{
    using System.Reflection;

    class Program
    {
        public delegate int MathOperation(int a, int b); // with a func, we can not write this code

        // C# includes built-in generic delegate types Func and Action, so that you don't need to define custom delegates manually in most cases.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // old
            MathOperation operation;
            operation = Add;
            operation = Diff;

            // new
            Func<int, int, int> operation2;
            // The last parameter in the angle brackets <> is considered the return type, and the remaining parameters are considered input parameter types, as shown in the following figure.

            operation2 = Add;
            operation2 = Diff;

            var result = operation2(10, 20);
            Console.WriteLine(result);

            // how parameters are mapped
            Func<string, double, int> a = CheckTypes;

            // inline delegate
            Func<int, int> someInlineDelegate = param =>
            {
                return 21;
            };

            Func<int, string> someInlineDelegate2 = param =>
            {
                return "ceva";
            };
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Diff(int a, int b)
        {
            return a - b;
        }

        static int CheckTypes(string a, double b)
        {
            return 0;
        }
    }
}
