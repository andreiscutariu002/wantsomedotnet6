namespace Week05.OOP2._2_Inheritance
{
    using System;

    public abstract class Employee 
    {
        //// not ok
        //public Employee()
        //{
        //}

        protected Employee(string cnp, string salary)
        {
            Console.WriteLine("Employee instance created");
            this.Cnp = cnp;
            this.Salary = salary;
        }

        public abstract bool CanBeFired { get; }

        public string Name { get; set; }

        public string Cnp { get; set; }

        public string Salary { get; set; }

        public Address Address { get; set; }

        public static int SomeStaticField { get; set; }

        internal void InternalMethod()
        {
        }

        protected internal void ProtectedInternalMethod()
        {
        }

        protected void ProtectedMethod()
        {
        }

        public void PublicMethod()
        {
        }

        private void PrivateMethod()
        {
        }
    }

    //public class DummyEmployee : Employee
    //{
    //    // by default
    //    public DummyEmployee() : base()
    //    {
    //    }
    //}
}
