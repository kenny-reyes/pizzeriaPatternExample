using Pizzeria.Domain.Pizzas;

namespace Pizzeria.Domain.Factories
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public class CarbonaraPizzaFactory : PizzaFactory
    {
        public override Pizza GetPizza() => new CarbonaraPizza();
    }
}
