namespace Pizzeria.Domain.Ingredients
{
    public class Corn : Ingredient
    {
        public override string Name => "Maiz";

        public override string ImagePath => @"Resources\Corn.png";

        public override IngredientType Type => IngredientType.Vegetal;
    }
}
