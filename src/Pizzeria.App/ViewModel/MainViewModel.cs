using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
using Pizzeria.Domain.Base;
using System;
using System.Windows.Input;

namespace Pizzeria.App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Pizza _selectedPizza;

        public MainViewModel()
        {
            ModifyPizzaCommand = new RelayCommand(ModifyPizza, CanModifyPizza);
            NewPizzaCommand = new RelayCommand(NewPizza);
            OrderPizzaCommand = new RelayCommand(OrderPizza, CanOrderPizza);
        }

        public ICommand ModifyPizzaCommand { get; private set; }
        public ICommand NewPizzaCommand { get; private set; }
        public ICommand OrderPizzaCommand { get; private set; }

        /// <summary>
        /// Using Singleton
        /// </summary>
        public PizzaList Pizzas => PizzaList.Instance;

        public OrderList Orders => OrderList.Instance;

        public Pizza SelectedPizza
        {
            set
            {
                _selectedPizza = value;
                OnPropertyChanged("SelectedPizza");
            }
            get
            {
                return _selectedPizza;
            }
        }

        public void ModifyPizza()
        {
        }

        public bool CanModifyPizza()
        {
            return SelectedPizza != null ? true : false;
        }

        public void NewPizza()
        {
        }

        public void OrderPizza()
        {
        }

        public bool CanOrderPizza()
        {
            return SelectedPizza != null ? true : false;
        }
    }
}
