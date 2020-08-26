using System;

namespace _09.Delegates.Predicate
{
    //Predicate is the delegate like Func and Action delegates. It represents a method containing a set of criteria and checks whether the passed parameter meets those criteria. A predicate delegate methods must take one input parameter and return a boolean - true or false.
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = IsUpperCase;

            Predicate<int> isPositive = param =>
            {
                var isPos = param > 0;

                return isPos;
            };

            bool res = isPositive(200);
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
