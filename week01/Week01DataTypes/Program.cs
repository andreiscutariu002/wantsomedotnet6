using System;

namespace Week01DataTypes
{
    // https://www.tutorialsteacher.com/csharp/csharp-data-types
    class Program
    {
        static void Main(string[] args)
        {
            // numeric data types
            int someIntValue = 1234;

            uint ui = 100u;
            float fl = 10.2f;
            long l = 45755452222222l;
            ulong ul = 45755452222222ul;
            double d = 11452222.555d;
            decimal mon = 1000.15m;

            // other types (char)
            char someChar = 'a';

            // string
            string someString = "abc";
            // value: a b c
            // pos:   0 1 2

            char firstChart = someString[0];

            Console.WriteLine(firstChart);
        }
    }
}
