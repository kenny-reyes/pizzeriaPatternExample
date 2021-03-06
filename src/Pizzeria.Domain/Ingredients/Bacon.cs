﻿using System;
using Pizzeria.Domain.Base;
using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Ingredients
{
    public class Bacon : Ingredient
    {
        public override string Name => "Bacon";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Bacon.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
