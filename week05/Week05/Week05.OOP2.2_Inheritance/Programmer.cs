namespace Week05.OOP2._2_Inheritance
{
    using System;

    // Inheritance
    // Programmer extends Employee
    // Programmer - derived class
    // Employee - base class
    public class Programmer : Employee
    {
        // Use the keyword base to invoke the parent constructor
        public Programmer() : base("default cnp", "default salary")
        {
            Console.WriteLine("Programmer instance created");
        }

        public Programmer(string cnp, string salary) : base(cnp, salary)
        {
            Console.WriteLine("Programmer instance created");
        }

        public string MainLanguage { get; set; }

        public void ChangeJob(string company)
        {
            SomeStaticField = -1;
        }

        public override bool CanBeFired
        {
            get { return true; }
        }
    }
}
