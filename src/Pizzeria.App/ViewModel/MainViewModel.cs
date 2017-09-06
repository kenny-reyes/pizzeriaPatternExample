using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
using Pizzeria.Domain.Base;

namespace Pizzeria.App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Pizzas.Add(new Four);
        }

        /// <summary>
        /// Using Singleton
        /// </summary>
        public PizzaList Pizzas => PizzaList.Instance;

        public OrderList Orders => OrderList.Instance;

    }
}
