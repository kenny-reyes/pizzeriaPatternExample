namespace Pizzeria.Domain.Ingredients
{
    public class Pineapple : Ingredient
    {
        public override string Name => "Piña";

        public override string ImagePath => @"\Resources\Pineapple.";

        public override IngredientType Type => IngredientType.Vegetal;
    }
}
