using System;

namespace Pizzeria.Domain.Ingredients
{
    public class Chicken : Ingredient
    {
        public override string Name => "Pollo";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Chicken.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
