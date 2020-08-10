using System;

namespace Week05.OOP2._1_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /*
     * Fields, constants, methods, properties, indexers, events, operators, constructors, destructors, …
     * Inner types (inner classes, structures, interfaces, delegates, ...)
     * Sablon pentru obiecte 
     */
    public class Student
    {
        public string Name { get; set; }

        public string Cnp { get; set; }

        public void CalculateGrade()
        {
            // 
        }
    }

    /*
     * Interfaces define a set of operations: Empty methods and properties, left to be implemented later
     * Sablon (contract) pentru clase 
     */
    public interface IStudent
    {
        string Name { get; set; }

        void CalculateGrade();
    }
}
