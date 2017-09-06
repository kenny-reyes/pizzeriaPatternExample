﻿namespace Pizzeria.Domain.Ingredients
{
    public class Bacon : Ingredient
    {
        public override string Name => "Bacon";

        public override string ImagePath => @"\Resources\Bacon.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
