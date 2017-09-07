using Pizzeria.Common.MVVM;
using Pizzeria.Domain;

namespace Pizzeria.App.ViewModel
{
    public class EditViewModel : ViewModelBase
    {
        private Pizza _pizzaToEdit;

        public EditViewModel(Pizza pizza)
        {
            PizzaToEdit = pizza;
        }

        public Pizza PizzaToEdit
        {
            get => _pizzaToEdit;
            set
            {
                _pizzaToEdit = value;
                OnPropertyChanged("PizzaToEdit");
            }
        }
    }
}
