﻿namespace Week05.OOP2._2_Inheritance
{
    using System;

    public class Employee 
    {
        //// not ok
        //public Employee()
        //{
        //}

        public Employee(string cnp, string salary)
        {
            Console.WriteLine("Employee instance created");
            this.Cnp = cnp;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public string Cnp { get; set; }

        public string Salary { get; set; }

        public Address Address { get; set; }

        public static int SomeStaticField { get; set; }
    }

    //public class DummyEmployee : Employee
    //{
    //    // by default
    //    public DummyEmployee() : base()
    //    {
    //    }
    //}
}
