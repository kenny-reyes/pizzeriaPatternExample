namespace Pizzeria.Domain.Ingredients
{
    public class Chicken : Ingredient
    {
        public override string Name => "Pollo";

        public override string ImagePath => @"\Resources\Chicken.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
