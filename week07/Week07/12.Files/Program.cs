using System;

namespace _12.Files
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText("C:\\Users\\matebook\\Desktop\\data.txt");

            Console.WriteLine(data);
        }
    }
}
