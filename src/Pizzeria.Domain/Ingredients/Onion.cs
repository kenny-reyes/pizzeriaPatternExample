using System;
using Pizzeria.Domain.Base;
using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Ingredients
{
    public class Onion : Ingredient
    {
        public override string Name => "Cebolla";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Onion.jpg";

        public override IngredientType Type => IngredientType.Vegetal;
    }
}
