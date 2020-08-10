namespace Week05.Homework
{
    using System;

    public class PizzaBase
    {
        public PizzaBase(PizzaBaseType type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

        public string Name { get; set; }

        // private field
        private decimal cost;

        // get and set for field cost
        public decimal Cost
        {
            get
            {
                if (this.Type == PizzaBaseType.Italian)
                {
                    return this.cost * (decimal) 1.5;
                }

                return this.cost;
            }
            set { this.cost = value; }
        }

        public PizzaBaseType Type { get; set; }

        public void Print()
        {
            Console.WriteLine($"Base: {this.Name}");
        }
    }
}
