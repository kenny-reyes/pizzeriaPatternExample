﻿using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
using Pizzeria.Domain.Base;
using System.Windows.Input;

namespace Pizzeria.App.ViewModel
{
    public class OrderPizzaViewModel : ViewModelBase
    {
        private Pizza _pizzaToEdit;
        private string _name;
        private string _phone;

        public OrderPizzaViewModel(Pizza pizza)
        {
            PizzaToOrder = pizza;
            OrderPizzaCommand = new RelayCommand(OrderPizza, CanOrderPizza);
        }

        public ICommand OrderPizzaCommand { get; private set; }

        public Pizza PizzaToOrder
        {
            get => _pizzaToEdit;
            set
            {
                _pizzaToEdit = value;
                OnPropertyChanged("PizzaToEdit");
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public void OrderPizza()
        {
            OrderList.Instance.Add(new Order { Name = Name, Phone = Phone, Pizza = PizzaToOrder });
        }

        public bool CanOrderPizza()
        {
            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Phone))
            {
                return true;
            }
            return false;
        }
    }
}
