using System;
using Pizzeria.Domain.Base;
using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Ingredients
{
    public class Eggs : Ingredient
    {
        public override string Name => "Huevo";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Eggs.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
