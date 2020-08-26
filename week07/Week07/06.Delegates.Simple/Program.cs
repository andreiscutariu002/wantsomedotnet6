using System;

namespace _06.Delegates.Simple
{
    // Parameters 
    // Parameters are sent to functions
    // Parameters types: predefined types (string, int, ..) + custom types (classes defined by user)

    // With delegates we can send functions as parameters
    // With delegates we keep a reference to an existing function
    class Program
    {
        public delegate void Print(string value);
        // Print is a delegate type
        // In a Print delegate we can store functions with this signature: void Method(string value)

        static void Main(string[] args)
        {
            Print function;

            function = PrintWithGreen;

            function("some message");

            SomeClass.Method(PrintWithRed);
        }

        public static void PrintWithRed(string data)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(data);
            Console.ResetColor();
        }

        public static void PrintWithGreen(string data)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(data);
            Console.ResetColor();
        }
    }

    class SomeClass
    {
        public static void Method(Program.Print function)
        {
            function("data");
        }
    }
}
