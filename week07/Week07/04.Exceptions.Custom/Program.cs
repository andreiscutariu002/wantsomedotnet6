using System;

namespace _04.Exceptions.Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunSomeMethod();
            }
            catch (LineFormatException e)
            {
            }
            catch (FormatException e)
            {
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
                throw new LineFormatException("Line is empty");
            }
        }
    }

    // o exceptie custom
    public class LineFormatException : FormatException
    {
        public LineFormatException(string message) : base(message)
        {
        }
    }
}
