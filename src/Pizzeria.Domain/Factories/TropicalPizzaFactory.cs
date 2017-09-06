using Pizzeria.Domain.Pizzas;

namespace Pizzeria.Domain.Factories
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public class TropicalPizzaFactory : PizzaFactory
    {
        public override Pizza GetPizza() => new TropicalPizza();
    }
}
