namespace Pizzeria.Domain.Factories
{
    /// <summary>
    /// Factory Pattern
    /// </summary>
    public abstract class PizzaFactory
    {
        public abstract Pizza GetPizza();
    }
}
