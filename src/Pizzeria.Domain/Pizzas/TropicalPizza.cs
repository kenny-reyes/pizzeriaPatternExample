using Pizzeria.Domain.Ingredients;
using System;

namespace Pizzeria.Domain.Pizzas
{
    public class TropicalPizza : Pizza
    {
        public TropicalPizza()
        {
            Name = "Tropical";
            ImagePath = @"\Resources\TropicalPizza.jpg";
            Ingredients = new IngredientList {
                new Mozzarella(),
                new Ham(),
                new Pineapple()
            };
        }
    }
}
