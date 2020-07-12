using System;

namespace Week01If
{
    //https://www.tutorialsteacher.com/csharp/csharp-if-else
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;

            var result = i < j;

            if (result)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
            }

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i == j)
            {
            } 
            else if (i < 20)
            {
            }
            else
            {
            }

            // C# - Ternary Operator ?:

            // condition ? statement 1 : statement 2

            int x = 20, y = 10;
            
            // 1
            var result2 = x > y ? "x is greater than y" : "x is less than y";

            // 2
            if (x > y)
            {
                result2 = "x is greater than y";
            }
            else
            {
                result2 = "x is less than y";
            }

            Console.WriteLine(result);
        }
    }
}
