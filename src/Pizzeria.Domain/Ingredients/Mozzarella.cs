﻿using System;

namespace Pizzeria.Domain.Ingredients
{
    public class Mozzarella : Ingredient
    {
        public override string Name => "Mozzarella";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Mozzarella.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
