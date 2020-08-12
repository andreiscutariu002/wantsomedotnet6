using System;

namespace Week05.OOP2._6_Polymorphism
{
    // Polymorphism
    // Base Type = Concept Abstractizat (comun)

    // Many sub-types of the same base-type
    // Comportament diferit in functie de context (tipul obiectul)
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager(1000);
            Employee programmer = new Programmer(2000);
            Employee superManager = new SuperManager(3000);
            Employee superSuperManager = new SuperSuperManager(3000);
            Employee teacher = new Teacher(1000);
            Employee manager2 = new Manager(1200);

            //Treat objects of a derived class as an object as a base class object

            var employeeManager = new EmployeeManager();
            
            employeeManager.Print(manager);
            employeeManager.Print(superManager);
            employeeManager.Print(superSuperManager);
        }
    }

    public class EmployeeManager
    {
        public void Print(Employee employee)
        {
            // comportamentul este diferit in functie de tipul derivat al clasei Employee
            var employeeSalary = employee.CalculateSalary();
            Console.WriteLine(employeeSalary);
        }
    }

    public abstract class Employee
    {
        protected decimal salary;

        protected Employee(decimal salary)
        {
            this.salary = salary;
        }

        public abstract decimal CalculateSalary();
    }
}