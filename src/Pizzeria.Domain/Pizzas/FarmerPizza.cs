using Pizzeria.Domain.Ingredients;

namespace Pizzeria.Domain.Pizzas
{
    public class FarmerPizza : Pizza
    {
        public FarmerPizza()
        {
            Name = "Granjera";
            ImagePath = @"\Resources\FarmerPizza.jpg";
            IngredientList = new IngredientList {
                new Mozzarella(),
                new BlueCheese(),
                new Parmesano(),
                new OldCheese()
            };
        }
    }
}
