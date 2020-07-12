using System;

namespace Week01ForWhile
{
    // https://www.tutorialsteacher.com/csharp/csharp-for-loop
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            int i2 = 0;
            while (i2 < 10) // condition
            {
                Console.WriteLine("i2 = {0}", i2);
                i2++; // increment
            }

            int i3 = 0;
            do
            {
                Console.WriteLine("i3 = {0}", i3);
                i3++;
            } while (i3 < 5);
        }
    }
}
