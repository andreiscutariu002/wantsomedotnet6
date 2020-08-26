using System;

namespace _06.Delegates.Multi
{
    //Delegate is the reference type data type that defines the signature.
    //Delegate type variable can refer to any method with the same signature as the delegate.
    //Syntax: [access modifier] delegate [return type][delegate name]([parameters])
    //A target method's signature must match with delegate signature.
    //Delegates can be invoke like a normal function or Invoke() method.
    //Multiple methods can be assigned to the delegate using "+" or "+=" operator and removed using "-" or "-=" operator. It is called multicast delegate.
    //If a multicast delegate returns a value then it returns the value from the last assigned target method.
    //Delegate is used to declare an event and anonymous methods in C#.

    class Program
    {
        public delegate void Print(string value);
        // Print is a delegate type
        // In a Print delegate we can store functions with this signature: void Method(string value)

        static void Main(string[] args)
        {
            Print function;

            // Multicast Delegate
            // The delegate can point to multiple methods. A delegate that points multiple methods is called a multicast delegate. The "+" or "+=" operator adds a function to the invocation list, and the "-" and "-=" operator removes it.
            function = PrintWithGreen;
            function += PrintWithRed;

            // remove a function from delegate
            //function -= PrintWithGreen;

            // inline delegate
            function += param =>
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(param);
                Console.ResetColor();
            };

            function("some message");
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
}
