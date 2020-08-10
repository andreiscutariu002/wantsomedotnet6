namespace Week05.OOP2._2_Inheritance
{
    using System.Globalization;

    /*
     * Access modifiers in C#
        public – access is not restricted
        private – access is restricted to the containing type
        protected – access is limited to the containing type and types derived from it
        internal – access is limited to the current assembly
        protected internal – access is limited to the current assembly or types derived from the containing class
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Programmer p = new Programmer();

            GeneralManager m = new GeneralManager("upoldas", "Mihai");

            m.FireEmployee("1234");

            m.PublicMethod();

            m.InternalMethod();
        }
    }
}
