using Pizzeria.Domain.Ingredients;

namespace Pizzeria.Domain.Pizzas
{
    public class FourCheesePizza : Pizza
    {
        public FourCheesePizza()
        {
            Name = "4 Quesos";
            ImagePath = @"\Resources\4Cheese.jpg";
            Ingredients = new IngredientList {
                new Mozzarella(),
                new BlueCheese(),
                new Parmesano(),
                new OldCheese()
            };
        }
    }
}
