namespace Week05.Homework
{
    using System;

    public class PizzaTopping
    {
        // object state
        public PizzaTopping(PizzaToppingType type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public PizzaToppingType Type { get; set; }

        public void Print()
        {
            if (this.Type == PizzaToppingType.Meat)
            {
                Console.WriteLine($"->  Name: {this.Name.ToUpper()}");
            }
            else
            {
                Console.WriteLine($"->  Name: {this.Name}");
            }
        }
    }
}
