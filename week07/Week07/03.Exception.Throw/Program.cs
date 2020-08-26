using System;

namespace _03.Exception.Throw
{
    using Exception = System.Exception;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunSomeMethod();
            }
            catch (ArgumentException e)
            {
            }
            catch (Exception e)
            {
            }
        }

        private static void RunSomeMethod()
        {
            var line = Console.ReadLine();

            if (string.IsNullOrEmpty(line))
            {
                // throw new exception, at line 27
                throw new ArgumentException("Line is empty");
            }
        }
    }
}
