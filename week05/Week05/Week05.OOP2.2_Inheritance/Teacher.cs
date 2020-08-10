namespace Week05.OOP2._2_Inheritance
{
    using System;

    public class Teacher : Employee
    {
        public Teacher(string cnp, string school) : base(cnp, "default")
        {
            Console.WriteLine("Teacher instance created");

            this.School = school;
        }

        public string School { get; set; }

        public override bool CanBeFired
        {
            get { return true; }
        }
    }
}
