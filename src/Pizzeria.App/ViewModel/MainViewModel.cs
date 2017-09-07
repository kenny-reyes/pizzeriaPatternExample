using Pizzeria.App.View;
using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
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

        public ICommand ModifyPizzaCommand { get; }
        public ICommand NewPizzaCommand { get; }
        public ICommand OrderPizzaCommand { get; }

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
            get => _selectedPizza;
        }

        public void ModifyPizza()
        {
            // This Breaks the MVVM pattern but it si more somple to explain
            EditView editView = new EditView();
            // Prototype usage
            editView.DataContext = new EditViewModel((Pizza)SelectedPizza.Clone(), editView);
            editView.Owner = System.Windows.Application.Current.MainWindow;
            editView.ShowDialog();
        }

        public bool CanModifyPizza()
        {
            return SelectedPizza != null ? true : false;
        }

        public void NewPizza()
        {
            EditView editView = new EditView();
            editView.DataContext = new EditViewModel(new Pizza { Name = "Pizza Custom", Ingredients = new IngredientList()}, editView);
            editView.Owner = System.Windows.Application.Current.MainWindow;
            editView.ShowDialog();
        }

        public void OrderPizza()
        {
            OrderPizzaView orderView = new OrderPizzaView();
            orderView.DataContext = new OrderPizzaViewModel(SelectedPizza, orderView);
            orderView.Owner = System.Windows.Application.Current.MainWindow;
            orderView.ShowDialog();
        }

        public bool CanOrderPizza()
        {
            return SelectedPizza != null;
        }
    }
}
