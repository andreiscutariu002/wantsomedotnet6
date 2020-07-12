using System;

namespace Week01Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            ////https://www.tutorialsteacher.com/csharp/csharp-operators#arithmetic-operators


            //// Arithmetic Operators


            //// Assignment Operators

            //int a;
            //a = 20; // Assignment

            ////x += 5;
            ////x = x + 5;


            //// Comparison Operators

            //int a1 = 0;
            //int b1 = 1;

            //bool result = a1 < b1;
            //bool result2 = a1 > b1;

            //bool result3 = a1 == b1; // egale
            //bool result4 = a1 != b1; // inegale

            //// Boolean Logical Operators
            //bool result5 = !result4;

            int c1 = 1; // 0001
            int c2 = 1; // 0001

            var cr1 = c1 & c2; // 0001

            Console.WriteLine(cr1);

            int d1 = 1; // 0001
            int d2 = 3; // 0011

            var dr1 = d1 & d2; // 0001
            var dr3 = d1 | d2; // 0011
            var dr4 = d1 ^ d2; // 0010

            Console.WriteLine(dr1);

            if (true & false)
            {
            }

            if (true && false) // conditional and
            {
            }

            int d = (3 * -3) * (3 / 3 + 5);
            // asignare
            // partea din dreapta se asigneaza 
            // partea din dreapta se evalueaza

            Range x = 1 .. 40;
        }
    }
}
