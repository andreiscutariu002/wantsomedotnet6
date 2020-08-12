namespace Week05.OOP2._6_Polymorphism
{
    public class Manager : Employee
    {
        public Manager(decimal salary) : base(salary)
        {
        }

        public override decimal CalculateSalary()
        {
            return this.salary * 1.1m;
        }
    }
}
