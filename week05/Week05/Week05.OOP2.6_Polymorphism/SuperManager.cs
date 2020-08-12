namespace Week05.OOP2._6_Polymorphism
{
    public class SuperManager : Manager
    {
        public SuperManager(decimal salary) : base(salary)
        {
        }
    }

    public class SuperSuperManager : SuperManager
    {
        public SuperSuperManager(decimal salary) : base(salary)
        {
        }

        public override decimal CalculateSalary()
        {
            return this.salary * 1.4m;
        }
    }
}
