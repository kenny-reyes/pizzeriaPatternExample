using System;

namespace Pizzeria.Domain.Ingredients
{
    public class Pancetta : Ingredient
    {
        public override string Name => "Panceta";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Pancetta.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
