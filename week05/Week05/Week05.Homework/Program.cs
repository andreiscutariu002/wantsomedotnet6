namespace Week05.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTopping topping = new PizzaTopping(PizzaToppingType.Cheese, "Cascaval")
            {
                Cost = 10
            };
            
            PizzaBase pizzaBase = new PizzaBase(PizzaBaseType.Italian, "Pizza Base 1")
            {
                Cost = 10
            };

            Pizza pizza = new Pizza(pizzaBase, "Pizza 1");

            pizza.AddTopping(topping);

            pizza.Print();
        }
    }
}