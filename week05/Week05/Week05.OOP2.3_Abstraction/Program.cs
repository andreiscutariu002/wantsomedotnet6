using System;

namespace Week05.OOP2._3_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Programmer p = new Programmer();
            //DoSomethingWithAnEmployee(p);

            //Manager m = new Manager();
            //DoSomethingWithAnEmployee(m);
        }

        public static void DoSomethingWithAnEmployee(IEmployee employee)
        {
            Console.WriteLine(employee.Name);

            Console.WriteLine(employee.Cnp);

            Console.WriteLine(employee.CalculateSalary());
        }
    }

    // interface - contract
    // cannot be instantiated
    public interface IEmployee
    {
        string Name { get; set; }

        string Cnp { get; set; }

        string Salary { get; set; }

        string CalculateSalary();

        // default method
        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }


    //Programmer, Teacher, Manager

    //implementation
    public class Programmer : IEmployee
    {
        public string Name { get; set; }

        public string Cnp { get; set; }

        public string Salary { get; set; }

        public string CalculateSalary()
        {
            return "";
        }
    }

    // implementation
    public class Teacher : IEmployee
    {
        public string Name { get; set; }

        public string Cnp { get; set; }

        public string Salary { get; set; }
        
        public string CalculateSalary()
        {
            return "";
        }
    }

    // implementation
    public class Manager : IEmployee
    {
        public string Name { get; set; }

        public string Cnp { get; set; }

        public string Salary { get; set; }

        public string CalculateSalary()
        {
            return "";
        }
    }
}
