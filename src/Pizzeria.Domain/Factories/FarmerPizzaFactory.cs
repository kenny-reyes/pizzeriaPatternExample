using Pizzeria.Domain.Base;
using Pizzeria.Domain.Pizzas;

namespace Pizzeria.Domain.Factories
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public class FarmerPizzaFactory : PizzaFactory
    {
        public override Pizza GetPizza() => new FarmerPizza();
    }
}
