using System;

namespace Pizzeria.Domain.Ingredients
{
    public class BlueCheese : Ingredient
    {
        public override string Name => "Queso Azul";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\BlueCheese.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
