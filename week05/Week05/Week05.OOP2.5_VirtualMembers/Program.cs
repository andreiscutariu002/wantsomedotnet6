using System;

namespace Week05.OOP2._5_VirtualMembers
{
    // nu pot fi instantiate
    public abstract class Employee
    {
        public string Cnp { get; set; }

        public string Email { get; set; }

        public virtual decimal Salary { get; set; }

        // virtual - permin suprascrierea acestei metode in clase derivate
        public virtual decimal CalculateSalary()
        {
            return this.Salary;
        }

        public abstract string GetEmployeeType();
    }

    public class Programmer : Employee
    {
        public string Language { get; set; }

        public override decimal Salary { get; set; }

        public override string GetEmployeeType()
        {
            return "Programmer";
        }
    }

    public class Teacher : Employee
    {
        public string School { get; set; }

        public override string GetEmployeeType()
        {
            return "Teacher";
        }

        public override decimal CalculateSalary()
        {
            return this.Salary * 0.9m;
        }
    }

    public class Manager : Employee
    {
        public override string GetEmployeeType()
        {
            return "Manager";
        }

        // suprascriere a metodei CalculateSalary
        // un alt comportament definit
        public override decimal CalculateSalary()
        {
            return this.Salary * 1.1m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var programmer = new Programmer
            {
                Cnp = "1234",
                Salary = 1234,
                Email = "andrei@site.com",
                Language = "C#"
            };

            var teacher = new Teacher
            {
                Cnp = "12344",
                Salary = 12345,
                Email = "dan@site.com",
                School = "New York"
            };

            var manager = new Manager()
            {
                Cnp = "12346",
                Salary = 1234500,
                Email = "ion@site.com",
            };

            PrintEmployeeDetails(programmer);
            PrintEmployeeDetails(teacher);
            PrintEmployeeDetails(manager);
        }

        private static void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"{employee.Email} - {employee.CalculateSalary()}");
        }
    }
}
