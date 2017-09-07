using Pizzeria.Domain.Base;
using Pizzeria.Domain.Pizzas;

namespace Pizzeria.Domain.Factories
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public class FourCheesePizzaFactory : PizzaFactory
    {
        public override Pizza GetPizza() => new FourCheesePizza();
    }
}
