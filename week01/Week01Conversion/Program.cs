using System;

namespace Week01Conversion
{
    // https://www.tutorialsteacher.com/csharp/csharp-data-types
    // Conversion - transform un tip de data in alt tip de data
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            // un tip de data mai mic -> mai mare

            Console.WriteLine("Hello World!");

            int i = 345;
            float f = i;

            // Explicit Conversion

            //int i2 = 100;
            //uint u = (uint)i2;
            //Console.Write(u);

            float f1 = 100.2f;
            uint u2 = (uint)f1;
            Console.WriteLine(u2);

            // string to int
            // https://www.tutorialsteacher.com/articles/convert-string-to-int

            string numberString = "1000";

            //int number = (int) numberString;

            int number = Convert.ToInt32(numberString);

            Console.WriteLine(number); // ca 1000 pe consola
            Console.WriteLine(numberString); // ca 1000 pe consola

            // comunicarea cu consola se face prin cartere
        }
    }
}
