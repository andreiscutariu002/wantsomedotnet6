using System;

namespace Week01Functions
{
    class Program
    {
        // functie

        // public - modificator de access [oop]
        // static - poate fi apelata fara a necesata o instanta [oop]

        // void - tipul de return al functiei

        // Main - numele functiei (id)

        // (string[] args) - parametri 

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int nr1 = 200;
            int nr2 = 300;

            var resNr12 = Add(nr1, nr2);
            Console.WriteLine(resNr12);

            int nr4 = 200;
            int nr5 = 600;

            var resNr45 = Add(nr4, nr5);
            Console.WriteLine(resNr45);
        }

        public static int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }
    }
}
