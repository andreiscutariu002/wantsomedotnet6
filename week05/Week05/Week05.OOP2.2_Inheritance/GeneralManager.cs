namespace Week05.OOP2._2_Inheritance
{
    using System;

    public class GeneralManager : Manager
    {
        public GeneralManager(string cnp, string name) : base(cnp, name)
        {
            Console.WriteLine("GeneralManager instance created");
        }

        //public new void FireEmployee(string cnp) // public void FireEmployee(string cnp)
        //{
        //    Console.WriteLine($"Do Not FireEmployee from GeneralManager with cnp {cnp}");
        //}

        public void SomeMethod()
        {
            this.ProtectedMethod();

            this.ProtectedInternalMethod();
        }
    }
}
