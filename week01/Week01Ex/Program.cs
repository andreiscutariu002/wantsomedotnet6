using System;

namespace Week01Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display even numbers between 0, 100

            Ex01();

            // 2.
            /*
             * Read 2 number from the keyboard and create mathematical operations for
                -division
                -multiplication
                -on division if the number is 0 display a message that it is not possible
                -calculate the minimum and maximum
             */

            Ex02();

            //3
            /*
             * Read a number from the keyboard and
                -it is the temperature in C, convert it to F
                -it is the temperature in F, convert it to C
                -it is a number of days, convert it to years, months, weeks and days
                Conventions - year: 365 days, month: 30 days, week: 7 days, use only numbers
                bigger than 1000
            */

            //4. Print to console all even numbers between 15 and 97.

            //5. Print all numbers divisible by 3 between 20 and 65.

            //6. Count all numbers divisible by 7 and multiple of 5, from 1400 to 2300 and print the result to console.

            //7. Write a program to guess a number between 1 and 10. To generate a random number, use Random class from .NET Framework.

            //9. Read a text from console and print it reversed.

            //10. Print numbers from 1 to 10 except 4 and 7.

            //11. Print the Fibonacci sequence from 0 to 50. (i.e. Exery next number is found by adding up those two before it: 0, 1, 1, 2, 3, 5, 8, 13, ..
        }

        public static void Ex01()
        {
            //for (int x = 0; x <=100; x = x + 1)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine("Value of x:{0}", x);
            //    }
            //}
            for (int x = 0; x <= 100; x = x + 2)
            {
                Console.WriteLine("Value of x:{0}", x);
            }
        }

        public static void Ex02()
        {

        }
    }
}
