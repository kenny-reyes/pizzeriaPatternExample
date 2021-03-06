﻿using System;
using Pizzeria.Domain.Base;
using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Ingredients
{
    public class Ham : Ingredient
    {
        public override string Name => "Jamon";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Ham.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
