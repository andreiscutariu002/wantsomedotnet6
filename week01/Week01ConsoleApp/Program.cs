using System;

namespace Week01ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Variables

            // <data type> <variable name> = <value>;

            // 1 - Numeric
            // 2 - Text (string)
            // 3 - Bool (true and false)

            // 4 - DateTime (Compus din numeric fields) (Year, Month, Day, Seconds ...)

            //int num = 100;
            // int - numeric data type

            // declare variable
            int num;

            // assing 
            num = 100;

            Console.WriteLine(num);

            //Variable names must be unique.
            //Variable names can contain letters, digits, and the underscore _ only.
            //Variable names must start with a letter.
            //Variable names are case-sensitive, num and Num are considered different names.
            //Variable names cannot contain reserved keywords. Must prefix @ before keyword if want reserve keywords as identifiers.

            // https://www.tutorialsteacher.com/csharp/csharp-keywords
        }
    }
}
