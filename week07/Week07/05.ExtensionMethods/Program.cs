using System;

namespace _05.ExtensionMethods
{
    //Extension methods are additional custom methods which were originally not included with the class.
    //Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
    //The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the this keyword.
    //Extension methods can be used anywhere in the application by including the namespace of the extension method.
    
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            // old code
            if (IsGreaterThanOld(number, 100))
            {
                Console.WriteLine("IsGreaterThan");
            }
            else
            {
                Console.WriteLine("IsNotGreaterThan");
            }

            if (number.IsGreaterThan(100)) // we need an extenstion method
            {
                Console.WriteLine("IsGreaterThan");
            }
            else
            {
                Console.WriteLine("IsNotGreaterThan");
            }

            // => on compile time

            if (LogicalExtension.IsGreaterThan(number, 100)) // we need an extenstion method
            {
                Console.WriteLine("IsGreaterThan");
            }
            else
            {
                Console.WriteLine("IsNotGreaterThan");
            }
        }

        static bool IsGreaterThanOld(int a, int b)
        {
            return a > b;
        }
    }

    public static class LogicalExtension
    {
        public static bool IsGreaterThan(this int a, int b)
        {
            return a > b;
        }
    }
}
