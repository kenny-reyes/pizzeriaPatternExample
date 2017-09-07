using System;
using System.Collections.ObjectModel;
using Pizzeria.Domain.Factories;

namespace Pizzeria.Domain
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class PizzaList : ObservableCollection<Pizza>
    {
        private static readonly Lazy<PizzaList> _instance = new Lazy<PizzaList>(() => new PizzaList());

        private PizzaList()
        {
            Add(new FourCheesePizzaFactory().GetPizza());
            Add(new CarbonaraPizzaFactory().GetPizza());
            Add(new TropicalPizzaFactory().GetPizza());
            Add(new FarmerPizzaFactory().GetPizza());
        }

        public static PizzaList Instance => _instance.Value;
    }
}
