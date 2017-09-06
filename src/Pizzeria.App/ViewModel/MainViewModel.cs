using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
using Pizzeria.Domain.Base;

namespace Pizzeria.App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Pizzas.Add(new Pizza("Test", "/Resources/Corn.png", new IngredientList()));
        }

        /// <summary>
        /// Using Singleton
        /// </summary>
        public PizzaList Pizzas => PizzaList.Instance;

        public OrderList Orders => OrderList.Instance;

    }
}
