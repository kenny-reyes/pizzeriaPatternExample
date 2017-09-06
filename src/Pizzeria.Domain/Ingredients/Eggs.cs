namespace Pizzeria.Domain.Ingredients
{
    public class Eggs : Ingredient
    {
        public override string Name => "Huevo";

        public override string ImagePath => @"\Resources\Eggs.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
