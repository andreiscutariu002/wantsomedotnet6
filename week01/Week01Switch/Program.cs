namespace Week01Switch
{
    using System;

    // https://www.tutorialsteacher.com/csharp/csharp-switch
    internal class Program
    {
        private static void Main(string[] args)
        {
            var value = "abcd";

            var first = value[0];

            switch (first)
            {
                case 'a':
                    Console.WriteLine("A");
                    int b = 1 + 2;
                    break;
                case 'b':
                    break;
                case 'z':
                    break;
            }
        }
    }
}
