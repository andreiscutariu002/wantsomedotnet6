using System;

namespace _02.Exception.Handle3.ExFilters
{
    using Exception = System.Exception;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine()); // FormatException

                Console.WriteLine($"Result is {1000 / num}"); // DivideByZeroException
            }
            // filtru pe handle exception [toate exceptiile trebuie sa fie mostenite de Exception]
            // order of catch clauses is important 
            catch (DivideByZeroException ex)
            {
                Console.Write("DivideByZeroException error occurred.");
            }
            catch (FormatException ex)
            {
                Console.Write("FormatException error occurred.");
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
        }
    }
}
