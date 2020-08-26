using System;

namespace _02.Exception.Handle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // put the code here that may raise exceptions

                // Any suspected code that may raise exceptions should be put inside a try{ } block. During the execution, if an exception occurs, the flow of the control jumps to the first matching catch block.
            }
            catch
            {
                // handle exception here

                // The catch block is an exception handler block where you can perform some action such as logging and auditing an exception. The catch block takes a parameter of an exception type using which you can get the details of an exception.

                // 1. HANDLE
                // 2. LOG EXCEPTION
                // 3. RE-THROW if needed
            }
            finally
            {
                // final cleanup code

                // The finally block will always be executed whether an exception raised or not. Usually, a finally block should be used to release resources, e.g., to close any stream or file objects that were opened in the try block.
            }
        }
    }
}
