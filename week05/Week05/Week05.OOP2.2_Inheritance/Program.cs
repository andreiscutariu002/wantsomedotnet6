namespace Week05.OOP2._2_Inheritance
{
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            //Programmer p = new Programmer();

            GeneralManager m = new GeneralManager("upoldas", "Mihai");

            m.FireEmployee("1234");
        }
    }
}
