using Pizzeria.Domain.Ingredients;

namespace Pizzeria.Domain.Pizzas
{
    public class CarbonaraPizza : Pizza
    {
        public CarbonaraPizza()
        {
            Name = "Carbonara";
            ImagePath = @"\Resources\CarbonaraPizza.jpg";
            Ingredients = new IngredientList {
                new Bacon(),
                new Pancetta(),
                new Onion(),
                new Eggs(),
                new Mozzarella(),
                new Parmesano()
            };
        }
    }
}
