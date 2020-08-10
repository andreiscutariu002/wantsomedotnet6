namespace Week05.OOP2._2_Inheritance
{
    using System;

    public class Manager : Employee
    {
        public Manager(string cnp, string name) : base(cnp.ToUpper(), "default")
        {
            Console.WriteLine("Manager instance created");

            this.Name = name;
        }

        public void FireEmployee(string cnp)
        {
            Console.WriteLine($"FireEmployee from Manager with cnp {cnp}");
        }
    }
}
