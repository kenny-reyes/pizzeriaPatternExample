using Pizzeria.Domain.Ingredients;

namespace Pizzeria.Domain.Pizzas
{
    public class FarmerPizza : Pizza
    {
        public FarmerPizza()
        {
            Name = "Granjera";
            ImagePath = @"\Resources\FarmerPizza.jpg";
            Ingredients = new IngredientList {
                new Mozzarella(),
                new Sausage(),
                new Onion(),
                new Corn(),
                new Chicken()
            };
        }
    }
}
