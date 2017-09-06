namespace Pizzeria.Domain.Ingredients
{
    public class Ham : Ingredient
    {
        public override string Name => "Jamon";

        public override string ImagePath => @"\Resources\Ham.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
