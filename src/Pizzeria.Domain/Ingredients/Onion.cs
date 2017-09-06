namespace Pizzeria.Domain.Ingredients
{
    public class Onion : Ingredient
    {
        public override string Name => "Cebolla";

        public override string ImagePath => @"\Resources\Onion.jpg";

        public override IngredientType Type => IngredientType.Vegetal;
    }
}
