namespace _01Exception.Simple
{
    using System;

    // Errors
    // 1. Compile Time ( Visual Studio Error )
    // 2. Runtime ( Exceptions )
    internal class Program
    {
        private static void Main(string[] args)
        {
            // compile error
            // var i = 1;
            // string s = i;

            // possible runtime error
            
            try // avem cod care pontetial, poate arunca exceptii
            {
                var line = Console.ReadLine();
                var number = int.Parse(line);
            }
            catch (Exception e) // handle (tratam) exceptii
            {
                Console.WriteLine("Error");
                //Console.WriteLine(e);
                //throw;
            }

            try
            {
            }
            catch // without Exception filter
            {
            }
        }
    }
}
