using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
using System.Windows;

namespace Pizzeria.App.ViewModel
{
    public class EditViewModel : ViewModelBase
    {
        private Pizza _pizzaToEdit;
        private Window _window;

        public EditViewModel(Pizza pizza, Window window)
        {
            PizzaToEdit = pizza;
            _window = window;
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
