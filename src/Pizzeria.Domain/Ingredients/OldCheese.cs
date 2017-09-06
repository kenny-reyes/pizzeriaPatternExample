namespace Pizzeria.Domain.Ingredients
{
    public class OldCheese : Ingredient
    {
        public override string Name => "Queso Viejo";

        public override string ImagePath => @"\Resources\OldCheese.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
