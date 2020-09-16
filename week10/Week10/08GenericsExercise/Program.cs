using System;

namespace _08GenericsExercise
{
    class Program
    {

        // Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
        // Keep the elements of the list in an array with a fixed capacity which is given as a parameter in the class constructor.
        // Implement methods for:
            // Add element. If the capacity is exceeded, throw an exception [ex usage: list.Add(value)]
            // Get element by index. [ex usage: var data = list.Get(2)]. Element on position 2 will be returned. 
            // Removing element by index. [ex usage: var data = list.Remove(2)]. Element on position 2 will be removed. 
            // Inserting an element at a given position. [ex usage: list.Add(10, 2). 10 will be inserted on position 2. 
                // Elements from the position 2 will be moved with one position. If capacity is exceeded, the last element will be removed.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
