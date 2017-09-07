﻿using System;

namespace Pizzeria.Domain.Ingredients
{
    public class Pineapple : Ingredient
    {
        public override string Name => "Piña";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Pineapple.jpg";

        public override IngredientType Type => IngredientType.Vegetal;
    }
}
