namespace Week05.OOP2._2_Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /*
     * Access modifiers in C#
        public – access is not restricted
        private – access is restricted to the containing type
        protected – access is limited to the containing type and types derived from it
        internal – access is limited to the current assembly
        protected internal – access is limited to the current assembly or types derived from the containing class
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Programmer p = new Programmer();

            GeneralManager generalManager = new GeneralManager("upoldas", "Mihai");
            Manager manager = new Manager("1234", "Vasile");
            Programmer programmer =  new Programmer("iqweq123", "100");
            Teacher teacher = new Teacher("123445", "Iasi 5");

            List<Employee> employees = new List<Employee>();

            employees.Add(generalManager);
            employees.Add(teacher);
            employees.Add(manager);
            employees.Add(programmer);

            Console.WriteLine();
            Console.WriteLine();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine();
            Console.WriteLine();

            manager.FireEmployee(teacher);
        }
    }
}
