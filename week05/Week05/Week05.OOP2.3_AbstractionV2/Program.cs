using System;

namespace Week05.OOP2._3_AbstractionV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Programmer e = new Programmer();

            e.CalculateSalary();
        }

        public static void DoSomethingWithAnEmployee(Employee employee)
        {
            Console.WriteLine(employee.Name);

            Console.WriteLine(employee.Cnp);

            Console.WriteLine(employee.CalculateSalary());
        }
    }

    public abstract class Employee
    {
        public abstract string Name { get; set; }

        // propritate care nu e abstracta 
        public string Cnp { get; set; }

        public abstract string Salary { get; set; }

        public abstract string CalculateSalary();

        // default method
        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class Programmer : Employee
    {
        public override string Name { get; set; }

        public override string Salary { get; set; }

        public override string CalculateSalary()
        {
            return "";
        }
    }

    public class Teacher : Employee
    {
        public override string Name { get; set; }

        public override string Salary { get; set; }

        public override string CalculateSalary()
        {
            return "";
        }
    }
}
