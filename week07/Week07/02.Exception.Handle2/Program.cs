using System;

namespace _02.Exception.Handle2
{
    using Exception = System.Exception;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            // filtru pe handle exception [toate exceptiile trebuie sa fie mostenite de Exception]
            catch (Exception ex)
            {
                Console.Write("Error occurred.");
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
        }
    }
}
