using Pizzeria.Domain.Ingredients;

namespace Pizzeria.Domain.Pizzas
{
    public class FourCheesePizza : Pizza
    {
        public FourCheesePizza()
        {
            Name = "4 Quesos";
            ImagePath = "4Cheese.jpg";
            IngredientList = new IngredientList {
                new Mozzarella(),
                new BlueCheese(),
                new Parmesano(),
                new OldCheese()
            };
        }
    }
}
