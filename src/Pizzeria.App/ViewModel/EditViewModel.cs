using System.Linq;
using Pizzeria.Common.MVVM;
using Pizzeria.Domain;
using System.Windows;
using System.Windows.Input;
using Pizzeria.App.View;
using Pizzeria.Domain.Base;
using Pizzeria.Domain.Ingredients;

namespace Pizzeria.App.ViewModel
{
    public class EditViewModel : ViewModelBase
    {
        private const int MaxNumberOfIngredients = 8;
        private Pizza _pizzaToEdit;
        private Window _window;
        private Ingredient _ingredientToAddSelected;
        private Ingredient _ingredientToRemoveSelected;
        private bool _isModify;

        public EditViewModel(Pizza pizza, Window window)
        {
            PizzaToEdit = pizza;
            _window = window;
            IngredientsToAdd = GetIngredientsToAdd(pizza);

            OrderPizzaCommand = new RelayCommand(OrderPizza);
            AddIngredientCommand = new RelayCommand(AddIngredient, CanAddIngredient);
            RemoveIngredientCommand = new RelayCommand(RemoveIngredient, CanRemoveIngredient);
        }

        public ICommand OrderPizzaCommand { get; }
        public ICommand AddIngredientCommand { get; }
        public ICommand RemoveIngredientCommand { get; }

        public Pizza PizzaToEdit
        {
            get => _pizzaToEdit;
            set
            {
                _pizzaToEdit = value;
                OnPropertyChanged("PizzaToEdit");
            }
        }

        public IngredientList IngredientsToAdd { get; }

        public Ingredient IngredientToAddSelected
        {
            get => _ingredientToAddSelected;
            set
            {
                _ingredientToAddSelected = value;
                OnPropertyChanged("IngredientToAddSelected");
            }
        }

        public Ingredient IngredientToRemoveSelected
        {
            get => _ingredientToRemoveSelected;
            set
            {
                _ingredientToRemoveSelected = value;
                OnPropertyChanged("IngredientToRemoveSelected");
            }
        }

        public void OrderPizza()
        {
            OrderPizzaView orderView = new OrderPizzaView();
            orderView.DataContext = new OrderPizzaViewModel(PizzaToEdit, orderView);
            orderView.Owner = Application.Current.MainWindow;
            _window.Close();
            orderView.ShowDialog();
        }

        public void AddIngredient()
        {
            if (!_isModify)
            {
                _isModify = true;
                PizzaToEdit.Name += " (Modificada)";
            }
            PizzaToEdit.Ingredients.Add(IngredientToAddSelected);
            RemoveByType(IngredientsToAdd, IngredientToAddSelected);
        }

        public bool CanAddIngredient()
        {
            if (IngredientToAddSelected != null && _pizzaToEdit.Ingredients.Count < MaxNumberOfIngredients)
            {
                return true;
            }
            return false;
        }

        public void RemoveIngredient()
        {
            if (!_isModify)
            {
                _isModify = true;
                PizzaToEdit.Name += " (Modificada)";
            }
            IngredientsToAdd.Add(IngredientToRemoveSelected);
            RemoveByType(PizzaToEdit.Ingredients, IngredientToRemoveSelected);
        }

        public bool CanRemoveIngredient()
        {
            return IngredientToRemoveSelected != null;
        }

        private IngredientList GetIngredientsToAdd(Pizza pizza)
        {
            var ingredients = new IngredientList
            {
                new Bacon(),
                new BlueCheese(),
                new Chicken(),
                new Corn(),
                new Eggs(),
                new Ham(),
                new Mozzarella(),
                new OldCheese(),
                new Onion(),
                new Pancetta(),
                new Parmesano(),
                new Pineapple(),
                new Sausage()
            };
            foreach (var item in pizza.Ingredients)
            {
                RemoveByType(ingredients, item);
            }
            return ingredients;
        }

        private void RemoveByType(IngredientList list, Ingredient ingredient)
        {
            if (list != null)
            {
                var toRemove = list.Where(element => element.GetType() == ingredient.GetType()).ToList();

                foreach (var item in toRemove) list.Remove(item);
            }
        }
    }
}
