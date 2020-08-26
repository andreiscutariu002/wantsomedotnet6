using System;

namespace _03.Exception.ThrowV2
{
    using Exception = System.Exception;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                try
                {
                    var num = int.Parse(Console.ReadLine()); // FormatException
                    Console.WriteLine($"Result is {1000 / num}"); // DivideByZeroException
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    throw e; // pierdem stack trace curent 
                }
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
