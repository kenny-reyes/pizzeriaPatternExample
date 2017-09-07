using System;

namespace Pizzeria.Domain.Ingredients
{
    public class Onion : Ingredient
    {
        public override string Name => "Cebolla";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Onion.jpg";

        public override IngredientType Type => IngredientType.Vegetal;
    }
}
