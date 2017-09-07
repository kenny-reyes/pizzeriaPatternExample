namespace Pizzeria.Domain.Base
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public abstract class PizzaFactory
    {
        public abstract Pizza GetPizza();
    }
}
