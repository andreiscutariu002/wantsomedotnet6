namespace Week05.Homework
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        public Pizza(PizzaBase pizzaBase, string name)
        {
            this.PizzaBase = pizzaBase;
            this.Name = name;
            this.Toppings = new List<PizzaTopping>();
        }

        public string Name { get; set; }

        public PizzaBase PizzaBase { get; set; }

        public List<PizzaTopping> Toppings { get; set; }

        public void AddTopping(PizzaTopping topping)
        {
            this.Toppings.Add(topping);
        }

        public decimal CalculateTotalCost()
        {
            var sum = 0m;

            sum += this.PizzaBase.Cost;

            foreach (var pizzaTopping in this.Toppings)
            {
                sum += pizzaTopping.Cost;
            }

            return sum;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza: {this.Name}");
            this.PizzaBase.Print();
            foreach (var topping in Toppings)
            {
                topping.Print();
            }

            Console.WriteLine($"Cost: {this.CalculateTotalCost()}");
        }
    }
}
