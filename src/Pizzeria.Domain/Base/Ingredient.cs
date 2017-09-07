using Pizzeria.Domain.Enums;

namespace Pizzeria.Domain.Base
{
    public abstract class Ingredient
    {
        public abstract string Name { get; } 

        public abstract string ImagePath { get; }

        public abstract IngredientType Type { get; }
    }
}
