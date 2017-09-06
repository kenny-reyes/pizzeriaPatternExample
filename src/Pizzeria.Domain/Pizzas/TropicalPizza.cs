using Pizzeria.Domain.Ingredients;

namespace Pizzeria.Domain.Pizzas
{
    public class TropicalPizza : Pizza
    {
        public TropicalPizza()
        {
            Name = "Tropical";
            ImagePath = @"\Resources\TropicalPizza.jpg";
            IngredientList = new IngredientList {
                new Mozzarella(),
                new BlueCheese(),
                new Parmesano(),
                new OldCheese()
            };
        }
    }
}
