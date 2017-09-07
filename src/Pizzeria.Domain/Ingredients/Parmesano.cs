using System;
using Pizzeria.Domain.Base;
using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Ingredients
{
    public class Parmesano : Ingredient
    {
        public override string Name => "Paresano";

        public override string ImagePath => AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Parmesano.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
