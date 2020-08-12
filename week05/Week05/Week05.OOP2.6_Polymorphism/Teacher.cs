namespace Week05.OOP2._6_Polymorphism
{
    public class Teacher : Employee
    {
        public Teacher(decimal salary) : base(salary)
        {
        }

        public override decimal CalculateSalary()
        {
            return this.salary * 1.01m;
        }
    }
}
