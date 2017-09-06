using System;
using System.Collections.ObjectModel;

namespace Pizzeria.Domain.Base
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class PizzaList
    {
        private static readonly Lazy<ObservableCollection<Pizza>> _instance = new Lazy<ObservableCollection<Pizza>>(() => new ObservableCollection<Pizza>());

        private PizzaList()
        {
        }

        public static ObservableCollection<Pizza> Instance
        {
            get
            {
                return _instance.Value;
            }
        }
}
